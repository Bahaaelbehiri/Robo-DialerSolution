//Bahaa Elbehiri
//IT112
namespace Robo_Dialer
{
    class Program
    {
        static void Main(string[] args)
        {
            HomePhone h1 = new HomePhone();
            string companyName = string.Empty;
            string phoneNumber = string.Empty;
            string typePhone = string.Empty;
            // Console.WriteLine("Log in Please");
            // input dial number
            Console.WriteLine("Enter Dial() Number ");
            phoneNumber = String.Concat(Console.ReadLine().Where(c => !Char.IsWhiteSpace(c)));


            bool result = h1.Dial(phoneNumber);
            if (result)
            {
                typePhone = h1.phone_type;
                companyName = h1.company_name;
                phoneNumber = h1.phoneNumber;

                if (typePhone == "1")
                {
                    Console.WriteLine(companyName + " is being dialed using  1+" + phoneNumber);
                }
                else
                {
                    Console.WriteLine(companyName + " is being dialed using  " + phoneNumber);

                }

            }
            else
            {
                Console.WriteLine("The number that you have been dialed is wrong");

            }


           



            Console.ReadLine();
        }
    }
}
