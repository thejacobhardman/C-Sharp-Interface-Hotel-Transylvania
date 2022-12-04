using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Interfaces_Hotel_Transylvania
{
    internal class WaterMonster : Monster, IWaterMonster
    {
        public WaterMonster(string name, string type): base(name, type)
        {
            Name = name;
            Type = type;
        }

        public string Swim()
        {
            return "Going for a swim!";
        }
    }
}
