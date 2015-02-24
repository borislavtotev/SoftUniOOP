using System;
using System.Collections.Generic;
using System.Reflection;

namespace _04_GenericListVersion
{
    class Program
    {
        static void Main(string[] args)
        {
            // Check the GenericList class version
            System.Reflection.MemberInfo info = typeof(GenericList<>);
            object[] attributes = info.GetCustomAttributes(true);
            Console.WriteLine("Class GenericList<> Version: {0}",attributes[1]);

            // Check the version of the method Add
            MethodInfo[] methods = (typeof(GenericList<>)).GetMethods();
            foreach (var method in methods)
            {
                if (method.Name == "Add")
                {
                    object[] methodAttributes = method.GetCustomAttributes(true);
                    Console.WriteLine("Method Add Version: {0}", methodAttributes[0]);
                }
            }
        }
    }
}
