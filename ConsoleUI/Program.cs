using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {


            #region Vehicles





            // Create a list of Vehicle called vehicles
            var vehicles = new List<Vehicle>();

            /*
             * Create 4 instances: 1 Car, 1 Motorcycle, and then 2 instances of type Vehicle (use explicit typing) but use constuctors from derived classes
             * - new it up as one of each derived class
             * Set the properties with object initializer syntax
             */
           var focus = new Car() { HasTrunk = true, Make = "Ford", Model = "Focus", Year = 2013 };
           var motorcycle = new Motorcycle() { HasSideCart = true, Make = "HD", Model = "Chopper", Year = 1978 };

            Vehicle sedan = new Car() { HasTrunk = true, Make = "Dodge", Model = "Rango", Year = 2019 };
            Vehicle sport = new Car() { HasTrunk = false, Make = "Ferari", Model = "XL", Year = 2000 };




            /*
             * Add the 4 vehicles to the list
             * Using a foreach loop iterate over each of the properties
             */
            vehicles.Add(focus);
            vehicles.Add(motorcycle);
            vehicles.Add(sedan);
            vehicles.Add(sport);

            foreach (var veh in vehicles)
            {
                Console.WriteLine($"Make {veh.Make}, Model {veh.Model}, Year {veh.Year}");
                veh.DriveAbstract();
            }





            // Call each of the drive methods for one car and one motorcycle

            #endregion            
            Console.ReadLine();
        }
    }
}
