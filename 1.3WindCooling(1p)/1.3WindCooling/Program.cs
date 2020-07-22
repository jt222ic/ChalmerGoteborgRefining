using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._3WindCooling
{
    class Program
    {
        static int tablewidth = 40;
        static void Main(string[] args)
        {
            /// Oszevskis och Bluesteins formel 
            // Teff = 13.12+0.6215·T-13.956·v^(0.16)+0.48669·T·v^(0.16)
            /// Problem right now is to sort out the Console XNOR String format
            /// 
            
            Console.WriteLine();
            Console.WriteLine("======================================");
            Console.WriteLine("=vindens påverkan av tempratur       =");
            Console.WriteLine("=Presenteras i fin tabell            =");
            Console.WriteLine("======================================");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("   :                                                                   Temprature ºC                                         ");
            Console.Write("|||");
            Console.WriteLine(":         10      8      6      4      2      0     -2     -4     -6     -8    -10    -12    -14    -16    -18    -20    -22    -24    -26    -28    -30    ");
            Console.ResetColor();
            Console.WriteLine("=============================================================================================================================================================");
          
            for (int j =0; j<13; j++)
            {
                _for_specific(j);
                Console.WriteLine();
                Console.ResetColor();
            }
        }
        public static void _for_specific(int rows)
        {
                double[] Temprature = new double[21] { 10, 8, 6, 4, 2, 0, -2, -4, -6, -8, -10, -12, -14, -16, -18, -20, -22, -24, -26, -28, -30 };
                double[] Wind_In_M_S = new double[13] {2, 4, 6, 8, 10, 12, 14, 16, 18, 20, 22, 24, 26 };
              int Windcooling_Alogarithm;
              double LessThanMinusTwentyEight = -28; 
                                                           

            Console.ForegroundColor = ConsoleColor.White;
            int k = rows;
            switch(rows)
            {

                case 3: Console.Write("|v|");
                    break;

                case 4:
                    Console.Write("|i|");
                    break;

                case 5:
                    Console.Write("|n|");
                    break;

                case 6:
                    Console.Write("|d|");
                    break;

                case 8:
                    Console.Write("|<|");
                    break;


                case 9:
                    Console.Write("|m|");
                    break;

                case 10:
                    Console.Write("|/|");
                    break;

                case 11:
                    Console.Write("|s|");
                    break;

                case 12:
                    Console.Write("|>|");
                    break;

                default:
                    Console.Write("|||");
                    break;
            }
            Console.Write("{0,3}:   ", Wind_In_M_S[k]);           // the layout
            Console.ResetColor();

            for (int Horizontal = 0; Horizontal < Temprature.Length; Horizontal++)
                {
                    for (int Vertical = 0; Vertical < 1; Vertical++)   // 1 row 
                    {
                        Windcooling_Alogarithm = (int)Math.Round(13.12 + 0.6215 * Temprature[Horizontal] - 13.956 * Math.Pow(Wind_In_M_S[k], 0.16) + 0.48669 * Temprature[Horizontal] * Math.Pow(Wind_In_M_S[k], 0.16), MidpointRounding.AwayFromZero);

                    if (Windcooling_Alogarithm <= LessThanMinusTwentyEight)
                    {
                        Console.BackgroundColor = ConsoleColor.Cyan;
                        Console.ForegroundColor = ConsoleColor.Blue;
                    }
                    Console.Write("| {0,3} |", (int)Windcooling_Alogarithm);
                  
                    {
                    }
                }
                }
        }

        }
     
        }
    

    
        
    

   


