using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robo_Dialer
{
    class Phone
    {

        string _phone_type = "";
        string _company_name ="";
        string _phone_number ="";
        // arrays storing  all data (companyaname, phoneNumber, phoneType)
        private string[] companyname = { "CompuTest", "Curtis Manufacturing", "Data Functions","Donnay Repair", "ErgoNomic Inc",
                                          "Fox Bay Industries","Glare-Guard","Hazard Comm Specialists","Komfort Support"};
        private string[] phoneNum = { "(303) 985-5060", "(603) 532-4123", "(800) 876-2524","(708) 397-3330","(360) 434-3894",
                                           "(800) 969-4374", "(800) 874-8527","(800) 545-6254","(407) 783-6641","(714) 472-4409" };
        private string[] phonetype = { "1", "2", "1", "1", "1", "1", "2", "2", "2", "2" };

        // this holds the current phone
        private int _currentphone = -1;


        public bool Login(string phoneNamber)
        {
            for (int i = 0; i < phoneNum.Length; i++)
            {
                if (String.Concat(phoneNum[i].Where(c => !Char.IsWhiteSpace(c))) == String.Concat(phoneNamber.Where(c => !Char.IsWhiteSpace(c))))
                {
                    _currentphone = i;
                    _phone_type = phonetype[i];
                    _company_name = companyname[i];
                    _phone_number = phoneNum[i];
                    return true;
                }
            }
            return false;
        }


        public void Logout()
        {
       
            _currentphone = -1;
        }

        public string company_name
        {
            get { return _company_name; }
        }
        public string type_phone
        {
            get { return _phone_type; }
        }
        public string phoneNumber
        {
            get { return _phone_number; }
        }

        public virtual void print(string companyName, string phoneNumber)
        {

        }
        
        public void printErrordialed()
        {
            Console.WriteLine("The number that you have been dailed is wrong");
        }



    }
}