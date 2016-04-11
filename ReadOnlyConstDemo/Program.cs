using System;
using AnotherAssembly;

namespace ReadOnlyConstDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(string.Format("readonly value: {0}", Library.ReadOnlyValue));
            Console.WriteLine(string.Format("const value: {0}", Library.ConstValue));
            Console.ReadKey();
        }
    }
}
