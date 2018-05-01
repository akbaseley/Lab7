using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Anna_Baseley_Lab7
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input
            //Processing (validation)
            //Output

            string UserName = GetUserInfo($"{"What is your first name?"}");
            UserName = VerifyName(UserName);
            Console.WriteLine($"Hi, {UserName}!");

            string UserEmail = GetUserInfo($"{"What is your e-mail address?"}");
            UserEmail = VerifyEmail(UserEmail);
            Console.WriteLine($"Thank you for your email!");

            string UserPhoneNumber = GetUserInfo($"{"What is your phone number?"}");
            UserPhoneNumber = VerifyPhoneNumber(UserPhoneNumber);
            Console.WriteLine($"Great! Thank you for your phone number!");

            string UserBirthday = GetUserInfo($"{"What is your birthday? dd/mm/yyyy"}");
            UserBirthday = VerifyBirthday(UserBirthday);
            Console.WriteLine($"Now I can both email and call you on your birthday, {UserName}!");

            string UserHTML = GetUserInfo($"{"What is your favorite HTML element? Include the <> brackets!"}");
            UserHTML = VerifyHTML(UserHTML);
            Console.WriteLine("Well done!");
           
        }

        public static string GetUserInfo(string message)
        {
            Console.WriteLine(message);
            string UserInfo = Console.ReadLine();
            return UserInfo;
        }
        public static string VerifyName(string UserName)
        {
            while(!Regex.IsMatch(UserName, @"^[A-Z{1}]+[a-zA-z{1,30}]+$"))
            {
                Console.WriteLine("Is that really your nname?  Please enter a valid name.");
                UserName = Console.ReadLine();
                return UserName;
            }
            return UserName;
        }
        public static string VerifyEmail(string UserEmail)
        {
            while(!Regex.IsMatch(UserEmail, @"^[a-zA-Z0-9{5,30}]+@[a-zA-A0-9{5,10}]+\.[a-zA-Z0-9{2,3}]+$"))
            {
                Console.WriteLine("Invalid E-Mail.  Please enter a valid e-mail address.");
                UserEmail = Console.ReadLine();
                return UserEmail;
            }
            return UserEmail;
        }
        public static string VerifyPhoneNumber(string UserPhoneNumber)
        {
            while(!Regex.IsMatch(UserPhoneNumber, @"^\d{10}$|^\d{3}\-\d{3}\-\d{4}$|^\d{3}\.\d{3}\.\d{4}$"))
            {
                Console.WriteLine("Invalid Phone Number.  Please enter a 10-digit phone number.");
                UserPhoneNumber = Console.ReadLine();
                return UserPhoneNumber;
            }
            return UserPhoneNumber;
        }
        public static string VerifyBirthday(string UserBirthday)
        {
            while(!Regex.IsMatch(UserBirthday, @"^(0?[1-9]|[12][0-9]|3[01])[\/\-](0?[1-9]|1[012])[\/\-]\d{4}$"))
            {
                Console.WriteLine("That's an invalid date! What's your birthday? dd/mm/yyyy");
                UserBirthday = Console.ReadLine();
                return UserBirthday;
            }
            return UserBirthday;
        }
        public static string VerifyHTML(string UserHTML)
        {
            while(Regex.IsMatch(UserHTML, @"^(\<[a-z{1}]\> \<\/[a-z{1}]\>)|(\<[a-z{1}]\d{0,9}\> \<\/[a-z{1}]\d{0,9}\>)$"))
            {
                Console.WriteLine("I don't think that's a valid HTML element!");
                UserHTML = Console.ReadLine();
                return UserHTML;
            }
            return UserHTML;
        }
    }
}
