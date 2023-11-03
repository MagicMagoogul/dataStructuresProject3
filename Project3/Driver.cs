///////////////////////////////////////////////////////////////////////////////
//
// Author: Riley Owen, owenrm1@etsu.edu, Josh 
// Course: CSCI-2210-001 - Data Structures
// Assignment: Project 3
// Description: 
//
///////////////////////////////////////////////////////////////////////////////

namespace Project3
{
    internal class Driver
    {
        /// <summary>
        ///  Output a report to the user with the results of the simulation in a text file.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //basic statistics
            int docksOpen = 0;
            int longestLine = 0;
            //totalTrucks increases once a truck has been processed.
            int totalTrucks = 0;
            int totalCrates = 0;
            int nextDock = 0;
            int nextDockID = 1;

            //Value related variables
            double totalValue = 0;
            double averageCrateVal = 0;
            double averageTruckVal = 0;
            int totalCost = 0;
            int totalRevenue = 0;

            //Time related variables
            int currentIncrement = 1;

            //entrance list
            Queue<Truck> gateLine = new Queue<Truck>();

            //list of docks
            Dock[] docks = new Dock[docksOpen];
            for (int d = 0; d < docksOpen; d++)
            {
                docks[d] = new Dock(nextDockID.ToString());
                nextDockID++;
            }

            //Incoming truck list and arrival intervals
            Queue<Schedule> schedule = new Queue<Schedule>(incomingTruckArrivals());
            //Console.WriteLine(schedule.Peek().GetTruck().ToString());

            //Begin Simulation
            for (int i = 1; i <= 48; i++)
            {

            }
        }

        /// <summary>
        /// Creates random intervals over the simulation period at which an unmade Truck object will "arrive" at the gate.
        /// </summary>
        /// <returns>Array of intervals corresponding to a truck's arrival interval</returns>
        public static List<Schedule> incomingTruckArrivals()
        {
            List<Schedule> arrivalIntervals = new List<Schedule>();
            Random rand = new Random();
            int totalTime = 10;
            int when;
            while (totalTime < 470)
            {
                when = rand.Next(5, 10);
                totalTime += when;
                Schedule entry = new Schedule(new Truck(), totalTime / 10);
                arrivalIntervals.Add(entry);
            }
            return arrivalIntervals;
        }


        //keeping this here in case the Schedule wrapper class falls through
        //public static Truck[] incomingTrucks(int[] truckAmount)
        //{
        //    Truck[] trucks = new Truck[truckAmount.Length];
        //    for (int i = 0; i < truckAmount.Length; i++)
        //    {
        //        trucks[i] = new Truck();
        //    }

        //    return trucks;
        //}
    }
}