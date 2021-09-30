using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pets_with_interfaces
{
    class Dog : IBark
    {
        public string Name { get; set; }
        public string Color { get; set; }
        public string BarkSound { get; set; } = "Woof";
        
        public string Bark()
        {
            return BarkSound;
        }
        public Dog(string Name, string Color) {
            this.Name = Name;
            this.Color = Color;
        }
    }
}
