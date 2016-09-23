using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace forSatsen
{
    class Program
    {
        static void Main(string[] args)
        {   //Övning1
            /*
            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine(i);
            }

            {
                Console.ReadKey();
            }
            */
            //Övning2
            /*
            for (int i = 20; i >= 1; i--)
            {
                Console.WriteLine(i);
            }

            {
                Console.ReadKey();
            }
            */
            //Övning3
            /*
            for (int i = 2; i <= 50; i = i + 2)
            {
                Console.WriteLine(i);
            }

            {
                Console.ReadKey();
            }
            */
            //Övning4
            /*
            Console.WriteLine("Mata in start:");
            int start = int.Parse(Console.ReadLine());
            Console.WriteLine("Mata in stop:");
            int stop = int.Parse(Console.ReadLine());
            Console.WriteLine("Mata in steg:");
            int steg = int.Parse(Console.ReadLine());

            for (int i = start; i < stop; i=i+steg)

            {
                Console.WriteLine(i);
            }

            {
                Console.ReadKey();
            }
            */
            //Övning6
            /*
            Console.WriteLine("Mata in ett heltal:");
            int heltal = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = heltal; i > 0; i--)
            {
                sum = sum + i;  
            }
            Console.WriteLine("Summan av alla heltal mellan 1 och " + heltal + " är:");
            Console.WriteLine(sum);
            Console.ReadKey();
            */
            //Övning7
            Console.WriteLine("Mata in ett heltal");
            int heltal = int.Parse(Console.ReadLine());

        }
    }
}
