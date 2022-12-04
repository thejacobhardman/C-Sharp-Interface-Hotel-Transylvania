using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Interfaces_Hotel_Transylvania
{
    internal class FlyingMonster : Monster, IFlyingMonster
    {
        public FlyingMonster(string name, string type): base(name, type)
        {
            Name = name;
            Type = type;
            InFlight = false;
        }

        protected bool InFlight;

        public void TakeOff() { InFlight = true; }

        public void Land() { InFlight = false; }
    }
}
