using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Interfaces_Hotel_Transylvania
{
    internal class InvisibleMonster : Monster, IInvisibleMonster
    {
        public InvisibleMonster(string name, string type): base(name, type)
        {
            Name = name;
            Type = type;
            VisibilityStatus = "Visible";
        }

        private string VisibilityStatus;

        public string GetVisibilityStatus()
        {
            return VisibilityStatus;
        }

        public void TurnInvisible()
        {
            VisibilityStatus = "Invisible";
        }

        public void TurnVisible()
        {
            VisibilityStatus = "Visible";
        }
    }
}
