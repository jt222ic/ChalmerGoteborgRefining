using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _2._3Password
{
    class Program
    {
        static string password_callback;
        static int reset = 0;
        static void callinback(string passwordFinal)             // repeating the process to main
        {
            password_callback = passwordFinal; 
        }
        static void Main(string[] args)
        {
            Password CurrentlyPassword;
            string password;
            int Condition = 0;     
                                                                           // main has some weird ass entry point
            CurrentlyPassword = new Password();                          // it will be 3 classes after 1 reset
            if (reset == 1)                                             // 1. original, 2. the temporary, 3rd the temp into the original.
            {
                CurrentlyPassword.Pass = password_callback;
                reset = 0;
                Console.WriteLine("Please input the New existence password Below:");
            }
            else
            {
                Console.WriteLine("Please input the existence password Below:");
            }
            while (true)
            {
                    password = Console.ReadLine();
                    if (password == CurrentlyPassword.Pass)
                    {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Correct, now it is available to change the Password");
                    Console.ResetColor();
                        break;
                    }
                    else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Wrong Password! Try again");
                }
                Console.ResetColor();
            }
            Console.WriteLine();
            Console.WriteLine("Condition for a new password:");
            Console.WriteLine("1.You need to have 8 letters");
            Console.WriteLine("2.Must contain special character");
            Console.WriteLine("3.Must contain 1 UPPER-CASE");
            Console.WriteLine("4.Must contain 1 LOWER-CASE");
            Console.WriteLine("5.Must contain 1 Number-letter");
            Console.WriteLine();

            while (true)
            {
                Condition = 0;
                Console.WriteLine("Input new Password:");
                //            ALTERNATIVE 2               ///
                //CurrentlyPassword.Testing = Console.ReadLine();                               // alternative solution 2   need to ask teacher
                                                                                               // create a new class to pass the pass constructor
                //if (CurrentlyPassword.ConditionCount >= CurrentlyPassword.Condition_Success)
                //{
                //    CurrentlyPassword.Pass = CurrentlyPassword.Testing;
                //    Console.ForegroundColor = ConsoleColor.Green;
                //    Console.WriteLine("COndition SUCCCESsful");
                //    Console.ResetColor();
                //    break;
                //}
                /////////////////////////////////////////////////////////////
                CurrentlyPassword = new Password();
                password = Console.ReadLine();
                if (CurrentlyPassword.Lessthan8string(password))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("You need to have 8 letters");
                }
                else
                {
                    Condition++;
                    //CurrentlyPassword.ConditionCount++;                   Alt: 2 depending how object oriented i should go
                }                                                                  // asking question about the way to use get set the best way
                if (CurrentlyPassword.DoesItcontainRegex(password))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Must contain special character");
                }
                else
                {
                    Condition++;
                    //CurrentlyPassword.ConditionCount++;
                }
                if (!CurrentlyPassword.OneUppercase(password))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Must contain at least 1 UPPER-CASE");
                }
                else
                {
                    Condition++;
                    //CurrentlyPassword.ConditionCount++;
                }
                if (!CurrentlyPassword.OneLowercase(password))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Must contain at least 1 LOWER-CASE");
                }
                else
                {
                    Condition++;
                    //CurrentlyPassword.ConditionCount++;
                }
                if (!CurrentlyPassword.OneDigit(password))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Must contain 1 Number-letter");
                }
                else
                {
                    Condition++;
                    //CurrentlyPassword.ConditionCount++;
                }
                Console.ResetColor();

                if (Condition >= CurrentlyPassword.Condition_Success)
                {
                    CurrentlyPassword.Pass = password;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("COndition SUCCCESsful");
                    Console.ResetColor();
                    break;
                }
                if (CurrentlyPassword.ConditionCount >= CurrentlyPassword.Condition_Success)  // alternative 2
                {

                    Console.WriteLine("Access properties working");
                }
            }
            while (true)
            {
                Console.WriteLine("Repeat the line:");
                password = Console.ReadLine();
                if (password != CurrentlyPassword.Pass)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("the condition is not the same");
                    Console.ResetColor();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("CORRECTION you obtained a new password");
                    Console.ResetColor();
                    Console.WriteLine();
                    Console.WriteLine();
                    reset = 1;
                    callinback(CurrentlyPassword.Pass);
                    Main(args);
                }
            }
        }
    }
    class Password
    {

        // field
        private string pass = "hej";                          // pre-registered password can used as constructor if you want
        private int condition_Success = 5;                     // standard condition     Alternative 2: Condition_success set to 4
        Regex regexItem = new Regex("^[a-zA-Z0-9]*$");
        private int conditioncount = 0;

        ////// alternative 2:
      //Regex regexUpper = new Regex("[A-Z]*$");
      //  Regex regexLower = new Regex("[a-z]");
      //  Regex regexNumber = new Regex("[0-9]");
      //  private string testing;
      //  private bool test_conditionsuccess;


        //Properties

        public string Pass
        { get
            {
                return pass;
            }
            set
            {
                pass = value;
            }
            }
        public int ConditionCount
        {
            get
            { 
                return conditioncount;
            }
            set
            {
                conditioncount = value;
            }
        }
        public int Condition_Success
        {
            get
            {
                return condition_Success;
            }
        }
        //public bool Test_conditionsuccess
        //{
        //    get
        //    {
        //        return test_conditionsuccess;
        //    }
        //    set
        //    {
        //        test_conditionsuccess = value;
        //    }
        //}

        //public string Testing  // extra time fixing :alternative solution 2 : too many possiblitlieis
        //{
        //    get
        //    {
        //        return testing;
        //    }
        //    set
        //    {
        //        conditioncount = 0;
        //            if (regexItem.IsMatch(value))
        //            {
        //                Console.ForegroundColor = ConsoleColor.Red;
        //                Console.WriteLine("Required Regular expression");
        //            }
        //            else
        //            {
        //                conditioncount++;
        //            }
        //            if (value.Length <= 8)
        //            {
        //                Console.ForegroundColor = ConsoleColor.Red;
        //                Console.WriteLine("You need to have 8 letters");
        //            }
        //            else
        //            {
        //                conditioncount++;
        //            }
        //            if (!regexNumber.IsMatch(value))
        //            {
        //                Console.ForegroundColor = ConsoleColor.Red;
        //                Console.WriteLine("You need a number");
        //            }
        //            else
        //            {
        //                conditioncount++;
        //            }
        //            if (!regexLower.IsMatch(value))
        //            {
        //                Console.ForegroundColor = ConsoleColor.Red;
        //                Console.WriteLine("You need a lower case");
        //            }
        //            else
        //            {
        //                conditioncount++;
        //            }
        //            if (regexUpper.IsMatch(value))
        //            {
        //                Console.ForegroundColor = ConsoleColor.Red;
        //                Console.WriteLine("You need an Upper case");
        //            }
        //            else
        //            {
        //                conditioncount++;
        //            }
        //        Console.ResetColor();
        //        testing = value;
        //    }
        //}

        public bool Lessthan8string(string password)
        {
            if(password.Length<=8)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool DoesItcontainRegex(string password)
        {
            if(regexItem.IsMatch(password))
            {
                return true;
            }

            return false;
        }
        public bool OneUppercase(string password)
        {
           
            foreach(char each in password)
            {
                if(char.IsUpper(each))
                {
                    return true;
                }   
            }
            return false;
        }
        public bool OneLowercase(string password)
        {
            foreach (char each in password)
            {
                if (char.IsLower(each))
                {
                    return true;
                }
            }
            return false;
            
        }
        public bool OneDigit(string password)
        {
            foreach (char each in password)
            {
                if (char.IsDigit(each))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
