using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {

            /// Skriv ett program som skapar ett fält med 10 000 slumptal mellan 0 och 9. 
            /// Programmet ska sedan visa hur många tvåor och nior det finns i fältet. 
            /// 
            int StoreTwo = 0;
            int StoreNine = 0;
            int StoreFive = 0;
            int AmountOfThree = 0;
            int[] StoreThree;
            List<int> StoreFour = new List<int>();
                                                 // variable to store the amount of Twos and Nines
            int N_times = 1000;                  // N times like Math, depending on how much your computer can handle 

            Random random = new Random();
            int RandomNumber = 0;
            for (int i = 0; i < N_times; i++)
            {
                RandomNumber = random.Next(0, 10);
                Console.WriteLine("{0}",RandomNumber);
                if(RandomNumber == 2)
                {
                    StoreTwo++;
                }
                if(RandomNumber == 9)
                {
                    StoreNine++;
                }
                if (RandomNumber == 3)
                {
                    AmountOfThree++;
                }
                if (RandomNumber == 4)
                {
                    StoreFour.Add(1);
                }
                
            }
            StoreThree = new int[AmountOfThree];
            Console.WriteLine("How many Twos is stored {0}", StoreTwo);
            Console.WriteLine("How many Nines is stored {0}", StoreNine);
            Console.WriteLine("How many Three is stored {0}", StoreThree.Count());
            Console.WriteLine("How many Four is stored {0}", StoreFour.Sum());
        

        }
    }
}
