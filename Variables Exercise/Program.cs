using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables_Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = "Big Boy";
            int x = 12;
            char c = '#';
            bool tf = true;
            double y = 2.33;
            decimal d = 5.4553m;
            Console.WriteLine($"My friend's name is {s}, he has {x} cylinders in his car. The hood of his car has a {c} on the front. I double checked to ensure it was {tf}.");
            Console.WriteLine($"{s}'s car goes zero to sixty in {y} seconds. He will be here in {d} minutes.");
        }

    }
}
