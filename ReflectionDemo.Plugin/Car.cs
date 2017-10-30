using ReflectionDemo.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionDemo.Plugin
{
    class Car : IVehicle
    {
        public string GetName()
        {
            return "car";
        }

        public void Ignate()
        {
            Console.WriteLine("grrrrrrr");
        }
    }
}
