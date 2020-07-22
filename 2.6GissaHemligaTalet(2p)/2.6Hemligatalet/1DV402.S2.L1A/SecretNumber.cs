using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1DV402.S2.L1A
{
    public class SecretNumber
    {                       /// FIELDSET
        private int _count;                      //// omgångar inmatning
        private int _number;                     //// nummersiffran under inmatning
        public const int  MaxNumberOfGuesses= 7;                   //// max 7 gissningar
        
       public void Initialize() {
           Random myRandom = new Random();
           _number = myRandom.Next(1,101);     //// random tilldelas från 1 till 100
           _count= 0;                          //// count tilldelas värdet 0

           //// värdet count går från 1-100
       }               
         public SecretNumber(){


            Initialize();               //// initialize konstruktor


        }

        public bool MakeGuess(int number)                  /// inmatning av värden som hämtas
        {
            if ( number<1||number>100)                     /// out of range exception
            {
                throw new ArgumentOutOfRangeException();   
            }          /// kastar om den överstiger 100 eller mindre
                                                                    ///   än 1

            if (_count < MaxNumberOfGuesses)
            {  
                ++_count;
                if (number < _number)                                   
                {
                    Console.WriteLine("{0} är för lågt. Du har {1} gissningar kvar.", number, (MaxNumberOfGuesses-_count));  
                }
                if (number > _number){
                Console.WriteLine("{0} är för högt. Du har {1} gissningar kvar.",number, (MaxNumberOfGuesses-_count));
                }
                if (number == _number)
                {
                    Console.WriteLine("Rätt Gissat. Du klarade på {0}.", (MaxNumberOfGuesses - _count));
                    return true;                          //// rätt på svar returnerar
                }

                if (_count == MaxNumberOfGuesses)
                {
                    Console.WriteLine("det hemliga talet är {0}", _number);
                               
                }
                return false;                                                  //// fel svar fortsätter med frågor

            }
            else
            {
                throw new ApplicationException();      //// kastar en ny argumentation exeption
                                                        /// för att count är större än numberOfGuess
            }                                           /// metoden
                                                             
            
        }
            ///// RPG CLASS ROLE
    }
    
}
    

