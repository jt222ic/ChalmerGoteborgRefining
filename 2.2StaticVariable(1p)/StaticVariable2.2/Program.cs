using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticVariable2._2
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Show Registered player  press 0 to add a player and press 1 to show all the available players");
            while (true)
            {
                int RegisterAlt = int.Parse(Console.ReadLine());
                switch (RegisterAlt)
                {
                    case 0:
                      
                        AfunctionReturn_AmoundOfObject();
                        break;
                    case 1:
                        Console.WriteLine("Access to static varaible such as numberof objects");
                        Console.WriteLine("{0}", variable_Of_Amount_Objects.numberofobjects);         // can access if i create a DAL class  // cannot access to object instance because of the local variaable
                        break;
            }
        }
        }
            static void AfunctionReturn_AmoundOfObject()
        {
            Random r_random = new Random();
            int RandomId = r_random.Next(1, 100);
            variable_Of_Amount_Objects k = new variable_Of_Amount_Objects("hej", RandomId);
        }
        class variable_Of_Amount_Objects  // readonly = fixed number
        {
            public String name;
            public readonly int idNumber;
            public static int numberofobjects = 0;

            public variable_Of_Amount_Objects(String name, int idNumber)
            {
                this.name = name;
                this.idNumber = idNumber;
                numberofobjects++;
            }
        }
    }
}
