using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
        static void Main()
        {
            string holder;
            double price;
            double weight;
            int height;
            int length;
            int width;
            double sum;

            Console.WriteLine("Package Weight:");
            holder = Console.ReadLine();
            weight = Convert.ToDouble(holder);
            if (weight <= 50)
            {
                Console.WriteLine("Package Width:");
                holder = Console.ReadLine();
                width = Convert.ToInt32(holder);

                Console.WriteLine("Package Height:");
                holder = Console.ReadLine();
                height = Convert.ToInt32(holder);

                Console.WriteLine("Package Length:");
                holder = Console.ReadLine();
                length = Convert.ToInt32(holder);

                sum = (length + width + height);

                if (sum <= 50)
                {
                    price = ((sum * weight)/100);
                    Console.WriteLine("Your estimated total is $" + price + " Thank you.");
                    Console.ReadLine();
                }
                else {
                    Console.WriteLine("Too big!");
                    Console.ReadLine();
                }

            }
            else
            {
                Console.WriteLine("Too heavy!");
                Console.ReadLine();
            }
        }
    }
}
