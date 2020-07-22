using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticUnderstanding
{
    class Program
    {
        static void Main(string[] args)
        {

                          // static only one copies, can be shared, instance by itself, Fast form
            jan++;

            Console.WriteLine("{0}", jan);
          

        }


        public static void hejsan()
        {

            Console.WriteLine("HEJ MONNIKA");
        }

        //public virtual static void tn()  *// so static cannot be override, abstract or virtual
        //{
        //  the scope of the static field is entire type.
        //}


        // static kan uppnå utan instance av ett object, kan kalla till variablen på dirren

        // non-instantiable


        // static has got Set(access variable) but only call for one instance



        // static is its own variable into itself Class, it is embedded to the memory
       // shared class can only reach to the main class which contain the static. Instance on its own in the class.
    }
}
