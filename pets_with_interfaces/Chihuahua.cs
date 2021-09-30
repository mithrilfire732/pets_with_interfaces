using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pets_with_interfaces
{
    class Chihuahua : Dog
    {
        public Chihuahua(string Name, string Color) : base(Name, Color) {
            BarkSound = "Yip";
        }
    }
}
