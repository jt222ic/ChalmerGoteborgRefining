using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParseRomanNumber1._10
{
    class Program
    {
        static void Main(string[] args)
        {
            // got help from https://social.msdn.microsoft.com/Forums/vstudio/en-US/600707d3-8053-4d4e-be0b-31c1f29690ad/c-roman-numeral-to-arabic-digits?forum=csharpgeneral
            string text;
            Console.WriteLine("Write down Romanics textnumber down");
            try
            {
                text = Console.ReadLine();
                int arabicNumber = Roman_Parse(text);



                Console.WriteLine("Arabic number {0}", arabicNumber);
                Console.WriteLine("string count {0}", text.Count());
            }
            catch (NotFiniteNumberException)
            {
                Console.WriteLine("fel");
            }
        }
        public static int Roman_Parse(string roman)
        {

           Dictionary<char,int> LookUp = new Dictionary<char, int>();                    // Setup a dictonary for each specific char for each unique Id
            LookUp.Add('I', 1);
            LookUp.Add('V', 5);
            LookUp.Add('X', 10);
            LookUp.Add('L', 50);
            LookUp.Add('C', 100);
            LookUp.Add('D', 500);
            LookUp.Add('M', 1000);

            int arabic= 0;

            
            for (int i = 0; i < roman.Count(); i++)                       // doesnt contain any number return 0
            {
                
                Console.WriteLine("Amound of loops{0}", i);
                if (!LookUp.ContainsKey(roman[i]))
                {
                    return 0;
                }

                if (i == roman.Count() - 1)                   // because i starts from 0    i reach to 1 and roman count is 2
                {
                    arabic += LookUp[roman[i]];                // find the specific id and key value and add in onto empty variable arabic
                }
                else
                {                                                                // the string contains array?
                    if (LookUp[roman[i + 1]] > LookUp[roman[i]])           // if the library hierarchy is bigger than you subtract
                    {
                        arabic -= LookUp[roman[i]];                     // if the right number is bigger than the left
                    }
                    else
                    {
                        arabic += LookUp[roman[i]];
                    }
                }
            }

            return arabic;

            
        }
    }

}

