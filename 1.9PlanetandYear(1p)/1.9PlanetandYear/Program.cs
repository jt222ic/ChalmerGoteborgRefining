using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._9PlanetandYear
{
    class Program
    {
        static void Main(string[] args)
        {

            Planet Earth = new Planet("Earth", 1, 365.25);

            Console.WriteLine("Planet: {0}, year {1}",Earth.Name, Earth.PlanetDays* 4);

            Console.WriteLine("Planet year times 10.0000", Earth.PlanetYear_in_decimal);

            Planet MyOwnPlanet = new Planet("MONSTA", 12, 91291939);
            Console.WriteLine("Planet: {0}, year {1}", MyOwnPlanet.Name, MyOwnPlanet.PlanetDays * 4);

            string input;
            Planet jan;
            
            
            jan = new Planet("", 0.2, 0.3);
            while (true)
            {
                Console.WriteLine("PLANETENS NAMN");
                input = Console.ReadLine();
                jan.Name = input;
                break;
            }
            while(true)
            {
                Console.WriteLine("PLANETENS år");
                input = Console.ReadLine();
                jan.PlanetYear_in_decimal = double.Parse(input);
                break;
            }
            while (true)
            {
                Console.WriteLine("PLANETENS dagar");
                input = Console.ReadLine();
                jan.PlanetDays = double.Parse(input);
                break;
            }
            Console.WriteLine("Planet: {0},YEAR{1},Days: {2}", jan.Name, jan.PlanetYear_in_decimal,jan.PlanetDays);
        }
    }
    class Planet
    {
        private string name;
        private double PlanetYear;
        private double PlanetDays_in_decimal;


        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }

        }
        public double PlanetDays
        {
            get
            {
                return PlanetDays_in_decimal;
            }
            set
            {
                PlanetYear_in_decimal = value;
            }

        }
        public double PlanetYear_in_decimal
            {
            get
            {
            return PlanetYear;
            }
            set
            {
                PlanetYear = PlanetDays_in_decimal * 10000;
                PlanetDays_in_decimal = value;
            }
            }

        public Planet(string name, double Year, double days)
        {

            this.name = name;
            this.PlanetYear = Year;
            this.PlanetDays_in_decimal = days;

        }


    }
}
