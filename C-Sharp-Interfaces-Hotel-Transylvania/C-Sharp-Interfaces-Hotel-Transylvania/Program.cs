using System;

namespace C_Sharp_Interfaces_Hotel_Transylvania
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hotel monsterHotel = new("Monster Hotel");

            bool isRunning = true;
            while (isRunning)
            {
                Console.Clear();
                Console.WriteLine("Welcome to the " + monsterHotel.Name + "'s booking interface.");

                bool validSelection = false;
                while (!validSelection)
                {
                    Console.WriteLine("\nPlease make a selection.");
                    Console.WriteLine("\n1. Make a new reservation. \n2. View current bookings. \n3. Quit.");
                    Console.Write("\nSelection: ");
                    string selection = Console.ReadLine();

                    if (selection == "1")
                    {
                        monsterHotel.NewBooking();
                        validSelection = true;
                    } else if (selection == "2")
                    {
                        Console.WriteLine(monsterHotel.ViewBookings());
                        validSelection = true;
                    } else if (selection == "3")
                    {
                        validSelection = true;
                        isRunning = false;
                    } else
                    {
                        Console.WriteLine("Please enter a valid selection.");
                    }
                }

                Console.WriteLine("\nPress any to continue.");
                Console.ReadKey();
            }

            Console.WriteLine("\nPress any key to close the program.");
            Console.ReadKey();
        }
    }
}