using System;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace ReflectionDemo
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=============Welcome to Reflection Demo============");

            TestCustomer test = new TestCustomer();
            test.TestType();
        }
    }
}
