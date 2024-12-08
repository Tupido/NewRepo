using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task10_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int totalMoney = 100; 
            int totalHeads = 100; 

            int bullPrice = 10; 
            int cowPrice = 5;   
            double calfPrice = 0.5; 

            for (int bulls = 0; bulls <= totalMoney / bullPrice; bulls++)
            {
                for (int cows = 0; cows <= (totalMoney - bulls * bullPrice) / cowPrice; cows++)
                {
                    int remainingMoney = totalMoney - (bulls * bullPrice + cows * cowPrice);
                    int calves = (int)(remainingMoney / calfPrice);

                    if (bulls + cows + calves == totalHeads)
                    {
                        Console.WriteLine($"Быков: {bulls}, Коров: {cows}, Теленков: {calves}");
                    }
                }
            }

            Console.ReadKey();
        }
    }
}
