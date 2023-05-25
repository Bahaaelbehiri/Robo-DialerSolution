using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robo_Dialer
{

    class CellPhone : Phone
    {
        public override void print(string companyName, string phoneNumber)
        {
            Console.WriteLine(companyName + " is being dialed using  1+" + phoneNumber);
        }
    }
}