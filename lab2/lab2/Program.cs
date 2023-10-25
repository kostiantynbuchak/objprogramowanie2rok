using System;
using lab2.constructions;

namespace lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            var constr = new Construction(23, 10, 4, 80, "brick");
            Console.WriteLine(constr.BuildMaterial);
        }
    }
}
