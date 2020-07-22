using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VaxelPengar1._2
{
    class Program
    {
        static void Main(string[] args)
        {


            double totalSum;
            double roundOff;
            double subTotal;
            int paid = 0;
            double back;

            while (true)
            {
                try
                {
                    Console.Write("Ange totalsumma      : ");
                    totalSum = Double.Parse(Console.ReadLine());


                    if (totalSum < 0.5)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Totalsumman är för liten, måste vara mer än 1!\n");
                        Console.ResetColor();
                        return;
                    }
                    else
                    {
                        Math.Round(totalSum, MidpointRounding.AwayFromZero);
                    }
                    break;
                }
                catch(FormatException)
                {
                    //catch      
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Fel format, endast siffror är tillåtna!\n");
                        Console.ResetColor();
                    }
                }
            }
            while (true)
            {
                try
                {
                    Console.Write("Ange erhållet belopp : ");
                    paid = int.Parse(Console.ReadLine());

                    if (paid < totalSum)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Det betalade beloppet är för lite, köpet kunde inte genomföras!\n");
                        Console.ResetColor();
                        return;
                    }
                    break;
                }
                catch (FormatException)                                     // experiment different try catch function
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Fel Format, endast siffror är tillåtna!\n");
                    Console.ResetColor();
                }
                catch (OverflowException)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Det betalade beloppet är för stort eller negativt. Försök igen.\n");
                    Console.ResetColor();
                }
            }
            //subTotal = (uint)Math.Round(totalSum, MidpointRounding.AwayFromZero);                // round off away from 0 but upward
            //roundOff = totalSum - subTotal;
            //back = paid - (uint)subTotal;



            subTotal = Math.Round(totalSum *2, MidpointRounding.AwayFromZero)/2;          // round off to 50 -öre
            roundOff = totalSum - subTotal;                                   // how much deca round
            back = paid - subTotal;
            // Presentera kvitto.
            Console.WriteLine();
            Console.WriteLine("KVITTO");
            Console.WriteLine("----------------------------------\n");
            Console.WriteLine(String.Format("Totalt            :{0,15:c}", totalSum));
            Console.WriteLine(String.Format("Öresavrunding     :{0,15:c}", roundOff));
            Console.WriteLine(String.Format("Att betala        :{0,15:c}", subTotal));
            Console.WriteLine(String.Format("Kontant           :{0,15:c}", paid));
            Console.WriteLine(String.Format("Tillbaka          :{0,15:c}\n", back));
            Console.WriteLine("----------------------------------\n");


            uint fivehudreds = 500;
            //uint twohundreds = 200;
            uint hundreds = 100;
            uint fiftio = 50;
            uint twenties = 20;                          /// update in sweden we have now 200 hundreds and 2kronors
            uint tens = 10;                               // I got the news recently 2020-03-04
            uint fives = 5;
            //uint twokrons = 2;
            uint ones = 1;
            double fiftioOre = 0.5;

            double temp = 0;                  // not recommend when using on update function


            temp = back / fivehudreds;
            back = back % fivehudreds;

            
            if (temp > 0)
            {
                Console.WriteLine("500-lappar : {0}", (int)temp);
            }
            //temp = back / twohundreds;
            //back = back % twohundreds;
        
            temp = back / hundreds;
            back = back % hundreds;
      
            if (temp > 0)
            {
                Console.WriteLine("100lappar : {0}", (int)temp);
            }
            temp = back / fiftio;
            back = back % fiftio;
         
            if (temp > 0)
            {
                Console.WriteLine("50lappar : {0}", (int)temp);
            }

            temp = back / twenties;
            back = back % twenties;
            
            if (temp > 0)
            {
                Console.WriteLine("20lappar:{0}", (int)temp);
            }
            temp = back / fives;
            back = back % fives;
            if (temp > 0)
            {

                Console.WriteLine("5 kronor:{0}", (int)temp);
            }
            temp = back / ones;
            back = back % ones;
            
            if (temp > 0)
            {
                Console.WriteLine("1 kronor:{0}", (int)temp);
            }
            temp = (uint)(back / fiftioOre);
            back = (uint)(back % fiftioOre);

            if (temp > 0)
            {
                Console.WriteLine("50 öre:{0}", temp);
            }
            Console.ResetColor();
        }
    }
    }

