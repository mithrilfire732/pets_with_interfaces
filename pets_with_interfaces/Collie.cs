using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pets_with_interfaces
{
    class Collie : Dog
    {
        public Collie(string Name, string Color) : base(Name, Color) {
            BarkSound = " Woof";
        }
    }
}
