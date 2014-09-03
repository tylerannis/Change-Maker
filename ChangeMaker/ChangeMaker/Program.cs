using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangeMaker
{
    class Program
    {
        static void Main(string[] args)
        {
            ChangeMaker(3.18);

            ChangeMaker(0.99);

            ChangeMaker(12.93);

            Console.ReadKey();
        }
        static void ChangeMaker(double amount)
        {
            //define counters for quarters, dimes, nickles, and pennies
            int quar = 0;
            int dimes = 0;
            int nick = 0;
            int penn = 0;
            //need a variable to store the orignial amount
            double oramount = amount;
            //make a loop for each of the counters and they are while loops
            while (amount >= .25)
            {
                amount -= .25;
                    quar++;
            }
            while (amount >= .10 && amount < .25)
            {
                amount -= .10;
                dimes++;
            }
            while (amount >= .05 && amount < .10)
            {
                amount -= .05;
                    nick++;
            }
            while (amount > .01)
            {
                amount -= .01;
                penn++;
            }
            //Print your counters in order that you want them
            Console.WriteLine("\nAmount: " + oramount);
            Console.WriteLine("Quarters: " + quar);
            Console.WriteLine("Dimes: " + dimes);
            Console.WriteLine("Nickles: " + nick);
            Console.WriteLine("Pennies: " + penn);
        }
    }
}
