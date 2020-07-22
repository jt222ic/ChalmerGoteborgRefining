using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _2._3cleanupPassword
{
    class Program
    {

       
        static void Main(string[] args)
        {
            Password CurrentlyPassword = new Password("F60gT%ft2$U");        // take hey its  easy
            while (true)
            {
                CurrentlyPassword.InputPassword = Console.ReadLine();
                if (CurrentlyPassword.SamePassword())
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Correct, now it is available to change the Password");
                    Console.ResetColor();
                    break;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.BackgroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Wrong Password! Try again");
                }
                Console.ResetColor();
            }
            while (true)
            {
                Console.WriteLine("Input new Password:");
                CurrentlyPassword = new Password("");
                CurrentlyPassword.InputPassword = Console.ReadLine();
                if (CurrentlyPassword.CheckPasswordCondition())
                {
                    CurrentlyPassword.PasswordChange();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("COndition SUCCCESsful");
                    Console.ResetColor();
                    break;
                }
            }
            while (true)
            {
                Console.WriteLine("Repeat the line:");
                CurrentlyPassword.InputPassword = Console.ReadLine();
                if (!CurrentlyPassword.SamePassword())
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
                    break;
                }
            }

        }
    }
    class Password
    {
        // field
        private string pass;                        
        private int condition_Success = 5;                    
        Regex regexItem = new Regex("^[a-zA-Z0-9]*$");
        private int conditioncount = 0;
        private string inputPassword;
        Regex regexUpper = new Regex("[A-Z]");         // doesnt work yet  Update: now works!... perhaps
        Regex regexLower = new Regex("[a-z]");
        Regex regexNumber = new Regex("[0-9]");

        // properties
        public string Pass
        {
            get
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
        public string InputPassword 
        {
            get
            {
                return inputPassword;
            }
            set
            {
                conditioncount = 0;
                if (regexItem.IsMatch(value))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Required Regular expression");
                }
                else
                {
                    conditioncount++;
                }
                if (value.Length <= 8)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("You need to have 8 letters");
                }
                else
                {
                    conditioncount++;
                }
                if (!regexNumber.IsMatch(value))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("You need a number");
                }
                else
                {
                    conditioncount++;
                }
                if (!regexLower.IsMatch(value))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("You need a lower case");
                }
                else
                {
                    conditioncount++;
                }
                if (!regexUpper.IsMatch(value))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("You need an Upper case");
                }
                else
                {
                    conditioncount++;
                }
                Console.ResetColor();
                inputPassword = value;
            }
        }
        // constructor
        public Password(string confirmedpassword)
        {
            this.Pass = confirmedpassword;
        }

        public string PasswordChange()
        {
            return pass = inputPassword;
        }

        public bool CheckPasswordCondition()
        {
            if (conditioncount >= condition_Success)
            {
                return true;
            }
                return false;
        }

        public bool SamePassword()
        {

           if(inputPassword == pass)
            {
                return true;
            }
            conditioncount = 0;
            return false;
            
        }
    }

}
