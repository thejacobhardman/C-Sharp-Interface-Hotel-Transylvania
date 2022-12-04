using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Interfaces_Hotel_Transylvania
{
    internal class Hotel
    {
        public Hotel(string name)
        {
            Name = name;
            Rooms = new List<Room>();
        }

        public string Name { get; set; }

        public List<Room> Rooms;

        public void NewBooking()
        {
            Console.Clear();
            Console.Write("Please enter the name of the monster that you would like to book a room for: ");
            string monsterName = Console.ReadLine();
            Console.WriteLine();

            Console.Write("Please enter the room number that you would like to book for the monster: ");
            string roomNumber = Console.ReadLine();
            Console.WriteLine();

            string monsterType = "";
            bool validType = false;
            while (!validType)
            {
                Console.Write("Please enter the type of monster that is making this booking ('Invisble', 'Water', 'Shape Shifting', or 'Flying'): ");
                monsterType = Console.ReadLine();

                if (monsterType.ToLower() == "invisible") {
                    InvisibleMonster newMonster = new(monsterName, monsterType);
                    Rooms.Add(new Room(newMonster, roomNumber));
                    validType = true; 
                }
                else if (monsterType.ToLower() == "water") {
                    WaterMonster newMonster = new(monsterName, monsterType);
                    Rooms.Add(new Room(newMonster, roomNumber));
                    validType = true; 
                }
                else if (monsterType.ToLower() == "shape shifting") {
                    ShapeShiftingMonster newMonster = new(monsterName, monsterType);
                    Rooms.Add(new Room(newMonster, roomNumber));
                    validType = true; 
                }
                else if (monsterType.ToLower() == "flying") {
                    FlyingMonster newMonster = new(monsterName, monsterType);
                    Rooms.Add(new Room(newMonster, roomNumber));
                    validType = true; 
                }
                else { Console.WriteLine("Please enter a valid monster type."); }
            }

            Console.WriteLine("\nRoom " + roomNumber + " has been booked for " + monsterName + " who is a " + monsterType + " monster.");
        }

        public string ViewBookings()
        {
            string bookings = "";

            if (Rooms.Count > 0)
            {
                foreach (Room room in Rooms)
                {
                    bookings += room.GetNumber() + ". - " + room.GetOccupantName() + " - " + room.GetOccupantType() + ".\n";
                }
            } else
            {
                bookings = "There are currently no rooms booked.";
            }

            return bookings;
        }
    }
}
