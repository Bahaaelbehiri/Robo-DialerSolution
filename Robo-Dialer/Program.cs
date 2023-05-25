//Bahaa Elbehiri
//IT112
namespace Robo_Dialer
{
    class Program
    {
        static void Main(string[] args)
        {
            HomePhone h1 = new HomePhone();
            CellPhone h2 = new CellPhone();
            string companyName = string.Empty;
            string phoneNumber = string.Empty;
               
            // input dial number
            Console.WriteLine("Enter Dial() Number ");
            phoneNumber = String.Concat(Console.ReadLine().Where(c => !Char.IsWhiteSpace(c)));
            
            
            bool result = h1.Login(phoneNumber);
            if (result)
            {
                companyName = h1.company_name;
                phoneNumber = h1.phoneNumber;
                if (h1.type_phone=="1")

                {
                    h2.print(companyName, phoneNumber);
                }
                else
                {
                    h1.print(companyName, phoneNumber);
                }
            }
             else
            {
                h1.printErrordialed();
    
            }

            


            Console.ReadLine();
        }
    }
}
