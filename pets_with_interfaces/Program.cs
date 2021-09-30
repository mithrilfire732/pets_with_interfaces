using System;
using System.Collections.Generic;

namespace pets_with_interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            var dogs = new List<IBark>()
            {
            new Collie("Lassie", "Golden"),
            new Boxer("Rip","Fawn"),
            new Chihuahua("Paso", "Tan")
            };
            foreach (var dog in dogs)
            {
                Console.WriteLine($"The dog barks {dog.Bark()}");
            }
            
        }
    }
}
