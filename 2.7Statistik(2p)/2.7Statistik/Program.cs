using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._7Statistik
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ange tio heltal till den första serien:");
            int NumberofHeltal = 0;
            int NumberofHeltal2 = 0;
            Statistik statistik = new Statistik();
            Statistik statistik2 = new Statistik();
            while (true)
            {
                try
                {
                    NumberofHeltal++;
                    string text = statistik.ToString();
                    text = Console.ReadLine();
                    if (NumberofHeltal < 10)
                    {
                        statistik.Add(int.Parse(text));
                    }
                    if (NumberofHeltal > 10)
                    {
                        //Console.WriteLine("Räkna ut Antal:{0}", statistik.Count);
                        //Console.WriteLine("Räkna ut Maxvärde:{0}", statistik.Max);
                        //Console.WriteLine("Räkna ut Minvärde:{0}", statistik.Min);
                        //Console.WriteLine("Räkna ut summa:{0}", statistik.Summa);
                        //Console.WriteLine("Räkna ut Medelvärde:{0}", statistik.Medel);
                        Console.WriteLine(statistik);
                        break;
                    }
                }
                catch (FormatException)
                {
                    LasHeltal(statistik);
                }
            }
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Ange tio heltal till den andra serien:");
            Console.WriteLine("----------------------------------------");
            while ( true)
            {
                try
                {
                    NumberofHeltal2++;
                    string text2 = statistik.ToString();
                    text2 = Console.ReadLine();
                    if (NumberofHeltal2 < 10)
                    {
                        statistik2.Add(int.Parse(text2));
                    }
                    if (NumberofHeltal2 > 10)
                    {

                        Console.Write(statistik2);
                        //Console.WriteLine("Räkna ut Antal:{0}", statistik2.Count);
                        //Console.WriteLine("Räkna ut Maxvärde:{0}", statistik2.Max);
                        //Console.WriteLine("Räkna ut Minvärde:{0}", statistik2.Min);
                        //Console.WriteLine("Räkna ut summa:{0}", statistik2.Summa);
                        //Console.WriteLine("Räkna ut Medelvärde:{0}", statistik2.Medel);
                        break;
                    }
                }
                catch(FormatException)
                {
                    LasHeltal(statistik2);
                }
            }

            if(statistik.Medel> statistik2.Medel)
            {
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.WriteLine("Första serien har större medelvärde");
                Console.ResetColor();
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.Green;
                Console.WriteLine("Andra serien har större medelvärde");
                Console.ResetColor();
            }
        }
         static void LasHeltal(Statistik statistik)
        {
            // error handling
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine("Inget Heltal");
            Console.WriteLine("Du måste ange ett heltal");
        }
    }
    class Statistik
    {
        // field
        private  int count;
        private int max;
        private int min;
        private int summa;
        private int amount;
        private double medelverde;
        List<int> Amount_Bitches = new List<int>();
        //properties 
        public int Count
        {
            get {
                return count;
            }
            set
            {
                
                count = value;
            }
        }
        public int Max
        {
            get
            {
                return max;
            }
            set
            {
                max = value;
            }
        }
        public int Min
        {
            get
            {
                return min;
            }
            set
            {
                min = value;
            }
        }
        public int Summa
        {
            get
            {
                return summa;
            }
            set
            {
                summa = value;
            }
        }
        public double Medel
        {
            get
            {
                return medelverde;
            }
            set
            {
                medelverde = value;
            }
        }
        public Statistik()
        {
        }
        public void Add(int value)
        {
            count++;
            this.Count = count;
            Amount_Bitches.Add(value);
            this.Max = Amount_Bitches.Max();
            this.Min = Amount_Bitches.Min();
            this.summa = Amount_Bitches.Sum();
            this.Medel = Amount_Bitches.Average();
        }
        public override string ToString()
        {
            return "Räkna ut Antal  " +this.Count+ "Räkna ut Maxvärd" + this.Max + "Räkna ut Minvärde"+this.Min+ "Räkna Summa" +this.Summa +"Medel" +this.Medel;            
        }
    }
}
