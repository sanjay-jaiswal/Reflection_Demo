using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace ReflectionDemo
{
    public class TestCustomer
    {
        public void TestType()
        {
            Type type = Type.GetType("ReflectionDemo.Customer");
            Console.WriteLine("Fetching customer class full name :" + type.FullName);
            Console.WriteLine("Fetching customer class name :" + type.Name);

            //Printing constructor
            Console.WriteLine("Constructor present in customer class ");
            ConstructorInfo[] constructors = type.GetConstructors();
            foreach(ConstructorInfo constructor in constructors)
            {
                Console.WriteLine(constructor.ToString());
            }

            //Printing methods
            Console.WriteLine("Method present in customer class");
            MethodInfo[] methods = type.GetMethods();
            foreach(MethodInfo methodInformation in methods)
            {
                Console.WriteLine(methodInformation.ToString());
            }

            //Printing properties
            Console.WriteLine("Properties present in customer class");
            PropertyInfo[] prop = type.GetProperties();
            foreach (PropertyInfo property in prop)
            {
                Console.WriteLine("Properties are {0} {1} " +property.PropertyType.Name+ " " +property.Name);
            }
        }
    }
}
