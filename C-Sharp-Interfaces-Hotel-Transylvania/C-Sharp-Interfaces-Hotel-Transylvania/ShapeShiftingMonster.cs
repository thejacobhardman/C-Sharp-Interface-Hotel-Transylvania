using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Interfaces_Hotel_Transylvania
{
    internal class ShapeShiftingMonster : Monster, IShapeShiftingMonster
    {
        public ShapeShiftingMonster(string name, string type): base(name, type)
        {
            Name = name;
            Type = type;
            Form = "Human";
        }

        protected string Form;

        public string ShapeShift(string newForm)
        {
            Form = newForm;
            return "Shapeshifting into " + Form;
        }
    }
}
