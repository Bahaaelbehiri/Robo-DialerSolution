using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Robo_Dialer
{
    class Phone
    {

        string _phonetype = "";
        string _company_name="";
        string _phone_number="";
        // Arrays for storing the entire data
        private string[] companyname = { "CompuTest", "Curtis Manufacturing", "Data Functions","Donnay Repair", "ErgoNomic Inc",
                                          "Fox Bay Industries","Glare-Guard","Hazard Comm Specialists","Komfort Support"};
        private string[] phoneNbr = { "(303) 985-5060", "(603) 532-4123", "(800) 876-2524","(708) 397-3330","(360) 434-3894",
                                           "(800) 969-4374", "(800) 874-8527","(800) 545-6254","(407) 783-6641","(714) 472-4409" };
        private string[] phonetype = { "1", "2", "1", "1", "1", "1", "2", "2", "2", "2" };

        // this holds the current phone's
        // location in the three arrays
        private int _currentphone = -1;


        public bool Dial(string phoneNamber)
        {
            for (int i = 0; i < phoneNbr.Length; i++)
            {
                if (String.Concat(phoneNbr[i].Where(c => !Char.IsWhiteSpace(c))) == String.Concat(phoneNamber.Where(c => !Char.IsWhiteSpace(c))))
                {
                    _currentphone = i;
                    _phonetype = phonetype[i];
                    _company_name = companyname[i];
                    _phone_number = phoneNbr[i];
                    return true;
                }
            }
            return false;
        }


        public void Logout()
        {
            // make sure no current user 
            // is pointed to after dialed
            _currentphone = -1;
        }

        public string company_name
        {
            get { return _company_name; }
          
        }
        public string phone_type
        {
            get { return _phonetype; }
          
        }
        public string phoneNumber
        {
            get { return _phone_number; }
          

        }




    }
}