using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BottlesOfBeer
{
    class BeerSong
    {
        public void Main()
        {
            Nintey_Nine_Bottles_of_Beer();
        }

        private void Nintey_Nine_Bottles_of_Beer()
        {
            string bottles;
            string bottlesMinus1;
            for (int i = 99; i >= 0; i--)
            {
                bottles = i.ToString();
                bottlesMinus1 = (i - 1).ToString();
                Console.WriteLine(bottles + " bottles of beer on the wall " + bottles + " bottles of beer.");
                if (bottlesMinus1 != "0")
                {
                    Console.WriteLine("Take one down, pass it around, " + bottlesMinus1 + " bottles of beer on the wall");
                }
                else
                {
                    Console.WriteLine("Take one down, pass it around, no more bottles of beer on the wall");
                }
            }
          
        }
    }
}
