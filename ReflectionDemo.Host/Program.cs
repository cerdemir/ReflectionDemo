using ReflectionDemo.Contracts;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionDemo.Host
{
    class Program
    {
        static void Main(string[] args)
        {
            String path = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            DirectoryInfo di = new DirectoryInfo(path);
            FileInfo[] files = di.GetFiles("*.dll");

            foreach (FileInfo file in files)
            {
                var assembly = Assembly.LoadFrom(file.FullName);
                var types= assembly.GetTypes();
                foreach (var type in types)
                {
                    var hasImplemented = type.GetInterfaces().Any(x => x == typeof(Contracts.IVehicle));
                    if (hasImplemented)
                    {
                        Console.WriteLine(type.FullName);
                        var vehicle = (IVehicle)assembly.CreateInstance(type.FullName);
                        vehicle.Ignate();
                        Console.WriteLine(vehicle.GetName());
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
