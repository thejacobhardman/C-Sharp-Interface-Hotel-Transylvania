using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Interfaces_Hotel_Transylvania
{
    internal class Room
    {
        public Room()
        {
            Occupant = "Unoccupied";
            Number = "1";
        }

        public Room(Monster monster, string number)
        {
            Occupant = monster.Name;
            OccupantType = monster.Type;
            Number = number;
        }

        private string Occupant;

        private string OccupantType;

        private string Number;

        public string GetOccupantName() { return Occupant; }

        public string GetOccupantType() { return OccupantType; }   

        public string GetNumber() { return Number; }
    }
}
