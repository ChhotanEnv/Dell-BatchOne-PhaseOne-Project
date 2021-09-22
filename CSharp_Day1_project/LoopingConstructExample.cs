using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Charp_Basics
{
    class LoopingConstructExample
    {
        static void Main(string[] args)
        {
            /*bool iNeedMoreCandles = true;
            int candleCount = 0;
            while (iNeedMoreCandles)
            {
                Console.WriteLine("Do you need one More Candle? Yes/No");
                string answer = Console.ReadLine();

                if (answer == "Yes")
                    candleCount++;
                else
                    iNeedMoreCandles = false;


            }
            Console.WriteLine("Candle Needed : {0}", candleCount);*/

            string[] pets = { "dog", "Cat", "bird" };
            for (int i=0;i< pets.Length; i++)
            {
                if (i == 1)
                    continue;
                Console.WriteLine(pets[i]);
            }

            Console.WriteLine("***********--------------------**********");
            foreach(string pet in pets)
            {

            }

            Console.ReadLine();
        }
    }
}
