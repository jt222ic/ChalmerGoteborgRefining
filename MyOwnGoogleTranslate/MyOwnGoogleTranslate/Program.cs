using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyOwnGoogleTranslate
{
    class Program
    {
        static void Main(string[] args)
        {

            // got help from https://social.msdn.microsoft.com/Forums/vstudio/en-US/600707d3-8053-4d4e-be0b-31c1f29690ad/c-roman-numeral-to-arabic-digits?forum=csharpgeneral
            string text;
            string jan;
            Console.WriteLine("Write down Romanics textnumber down");
            text = Console.ReadLine();
            jan = Jan_GoogleTranslate(text);
            Console.WriteLine("Orginal Text: {0}", text);
            Console.WriteLine("The new translated text : {0}", jan);

            // it works hurray
            // pick char instead of string if you want to search for everyinput


            //char text;
            //char jan;
            //Console.WriteLine("Write down Romanics textnumber down");
            //text = Console.ReadKey().KeyChar;
            //jan = returnera_Char(text);
            //Console.WriteLine("Orginal Text: {0}", text);
            //Console.WriteLine("The new translated text : {0}", jan);

        }
        public static string Jan_GoogleTranslate(string roman)
        {
            Dictionary<string, string> LookUp = new Dictionary<string, string>();                    // Setup a dictonary for each specific char for each unique Id
            LookUp.Add("a", "3e");
            LookUp.Add("b", "000");   // you can customised how you want to achieve your own lauguage

          

            for (int i = 0; i < roman.Count(); i++)                       // doesnt contain any number return 0
            {

                if (LookUp.ContainsKey(roman))
                {
                    string Value = LookUp[roman];
                    return Value;
                }

                if (!LookUp.ContainsKey(roman))
                {
                    return null;
                }
            }

            return null;
            //public static char returnera_Char(char roman)
            //{
            //    Dictionary<char, char> LookUp = new Dictionary<char, char>();                    // Setup a dictonary for each specific char for each unique Id
            //    LookUp.Add('a', 'e');
            //    LookUp.Add('b', '0');   // you can customised how you want to achieve your own lauguage

            //    if(LookUp.ContainsKey(roman))
            //    {
            //        char Value = LookUp[roman];
            //        return Value;
            //    }
            //    return Char.MinValue;
            //}
        }
    } 
}

    

