﻿///////////////////////////////////////////////////////////////////////////////
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
            //basic statistics for use in report
            int docksOpen = 20;
            int longestLine = 0;
            //totalTrucks increases once a truck has been processed.
            int totalTrucks = 0;
            int totalCrates = 0;
            int nextDock = 0;
            int nextDockID = 1;

            //Value related variables for use in report
            double totalValue = 0;
            double averageCrateVal = 0;
            double averageTruckVal = 0;
            double totalCost = 0;
            double totalRevenue = 0;


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

            //test code to ensure that schedule's arrival intervals are in order
            //while (schedule.Count() > 0)
            //{
            //    Console.WriteLine(schedule.Dequeue().GetArrivalInterval().ToString());
            //}



            //BEGIN SIMULATION
            for (int i = 0; i < 48; i++)
            {
                //trucks bound for that interval arrive at gate
                while (schedule.Peek().GetArrivalInterval() == i)
                {
                    gateLine.Enqueue(schedule.Dequeue().GetTruck());
                }

                //trucks at gate are sent to docks, in order of dock that has gone longest without receiving a truck
                while (gateLine.Count > 0)
                {
                    //sends truck to next dock, loops next dock if it is at end of indexes
                    if (nextDock < docks.Count() - 1)
                    {
                        docks[nextDock].JoinLine(gateLine.Dequeue());
                        //checks if the line at nextDock is longer than longestLine. If it is, makes that line the longest
                        if (docks[nextDock].Line.Count() > longestLine)
                        {
                            longestLine = docks[nextDock].Line.Count();
                        }
                        nextDock++;
                    }
                    else
                    {
                        docks[nextDock].JoinLine(gateLine.Dequeue());
                        //checks if the line at nextDock is longer than longestLine. If it is, makes that line the longest

                        if (docks[nextDock].Line.Count() > longestLine)
                        {
                            longestLine = docks[nextDock].Line.Count();
                        }
                        nextDock = 0;
                    }
                }

                //each dock unloads 1 crate, swapping out trucks if truck is empty
                foreach (Dock d in docks)
                {
                    d.UnloadCrate();
                }
                totalCost = totalCost + docksOpen * 100;
            }

            //at the end of the sim, adds up each dock object's recorded statistics into the final numbers
            foreach (Dock d in docks)
            {
                totalTrucks += d.TotalTrucks;
                totalCrates += d.TotalCrates;
                totalValue += d.TotalSales;
            }

            // end scenario statistics such as computed averages, as well a console line to display them
            averageCrateVal = totalValue / totalCrates;
            averageTruckVal = totalValue / totalTrucks;
            totalRevenue = totalValue - totalCost;
            Console.WriteLine($"{totalTrucks} trucks, {totalCrates} crates. {totalValue} earned from crates, {totalCost} in operating costs, {totalRevenue} overall revenue. {averageCrateVal} is average value per crate.");
        }

        /// <summary>
        /// Creates a list of random intervals within the simulation parameters that correspond to a Truck object.
        /// </summary>
        /// <returns>List of Schedule objects containing a truck object and the interval it will arrive at.</returns>
        public static List<Schedule> incomingTruckArrivals()
        {
            List<Schedule> arrivalIntervals = new List<Schedule>();
            Random rand = new Random();
            int totalTime = 0;
            int when;
            while (totalTime < 480)
            {
                when = rand.Next(5, 10);
                totalTime += when;
                Schedule entry = new Schedule(new Truck(), totalTime / 10);
                arrivalIntervals.Add(entry);
            }
            return arrivalIntervals;
        }
    }
}