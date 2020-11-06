using System;
using System.Globalization;
using System.Net.Mail;

namespace Assignment2
{
    // Creating class Student
    public class Student
    {
        // Creating variables
        public string FirstName;
        public string LastName;
        public string StudentID;
        public string email;
        public string DateOfBirth;

        public static void getDetail()
        {
            // Asking for user's input for each field
            Console.WriteLine("Please type your First Name :");
            string FirstName = Console.ReadLine();

            Console.WriteLine("Please type your Last Name :");
            string LastName = Console.ReadLine();

            Console.WriteLine("Please type your student ID number :");
            string StudentID = Console.ReadLine();

            Console.WriteLine("Please type your email address :");
            string email = Console.ReadLine();

            //Validation of email address
            if (IsValidEmail(email))
            {
                Console.WriteLine("Your email address is valid.");
            }
            else
            {
                Console.WriteLine("Please enter a valid email address!");
            }

            Console.WriteLine("Enter your Birth Date in the format dd/MM/yyyy : ");
            string dob = Console.ReadLine().ToString();
            var myDate = Convert.ToDateTime(dob);
            var today = DateTime.Today;
            var age = today.Year - myDate.Year;

            // Display the user's information
            if (myDate.Date > today.AddYears(-age)) age--;
            Console.WriteLine("Hi {0}, {1}, your studentID number is {2}, your email address is {3}, and you are {4} years old", FirstName, LastName, StudentID,
                email, age);

            int month = myDate.Month;
            int day = myDate.Day;
            int thismonth = today.Month;
            int thisday = today.Day;
            // Validate the user's age. If the user was born today, or if he has more than 105 years old, display correspondent messages
            if (myDate.Year == today.Year || myDate.Year > 2020)
            {
                Console.WriteLine("This birthday is invalid. User cannot be 0 years old or unborn");
            }
            if (myDate.Year <= 1915)
            {
                Console.WriteLine("I am sorry. The user cannot be more than 105 years old");
            }

            // Check if today is the user's birthday, if so, display a happy birthday message
            if (myDate.Day == today.Day && myDate.Month == today.Month)
            {
                Console.WriteLine("Happy Birthday {0}! I wish you many years of success on your coding! :)", FirstName);
            }

        }
        //Validation of email address
        private static bool IsValidEmail(string email)
        {
            try
            {
                MailAddress mail = new MailAddress(email);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
    }
    class Program
    {
        public static void Main(string[] args)
        {
            //Creating new object of Student class in the Program class
            Student student1 = new Student();
            //Calling the method getDetail from Student class
            Student.getDetail();
        }


    }
}