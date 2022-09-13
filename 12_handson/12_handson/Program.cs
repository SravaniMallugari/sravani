using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;
using System.Reflection;

namespace _12_handson
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string path = @"C:\dotnet\12_handson\ClassLibrary1\bin\Debug\ClassLibrary1.dll";
            Assembly asm = Assembly.LoadFrom(path);
            Type[] types = asm.GetTypes();
            Type t = null;
            foreach (var item in types)
            {
                Console.WriteLine(item.Name);
                Console.WriteLine(item.FullName);
                MemberInfo[] min = item.GetMembers();
                foreach (var item1 in min)
                {
                    Console.WriteLine(item1.Name);
                }
                MethodInfo[] max = item.GetMethods();
                foreach (var item2 in max)
                {
                    Console.WriteLine(item2.Name);

                    ParameterInfo[] pinfo = item2.GetParameters();
                    foreach (var p in pinfo)
                    {
                        Console.WriteLine("Parameter Name: " + p.Name);
                        Console.WriteLine("Parameter Position: " + p.Position);
                        Console.WriteLine("Parameter Type: " + p.ParameterType);
                    }
                }
                t = asm.GetType(item.FullName);
                object obj = Activator.CreateInstance(t);



                double cube = (double)item.InvokeMember("Cube1", BindingFlags.Public | BindingFlags.Instance | BindingFlags.InvokeMethod, null, obj, new object[1] { 400.0d });
                Console.WriteLine("Cube number is" + " " + cube);
                double sqrt = (double)item.InvokeMember("squareroot", BindingFlags.Public | BindingFlags.Instance | BindingFlags.InvokeMethod, null, obj, new object[1] { 200.0d });
                Console.WriteLine("Square root number is" + " " + sqrt);
                break;
            }
            Console.ReadLine();


        }
    }
}