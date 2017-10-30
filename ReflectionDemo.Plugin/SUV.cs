using ReflectionDemo.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionDemo.Plugin
{
    public class SUV : IVehicle
    {
        public string GetName()
        {
            return "suv";
        }

        public void Ignate()
        {
            Console.WriteLine("gurgurgurgurgurgurgur");
        }
    }
}
