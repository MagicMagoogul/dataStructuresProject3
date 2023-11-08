///////////////////////////////////////////////////////////////////////////////
//
// Author: Riley Owen, owenrm1@etsu.edu, Josh 
// Course: CSCI-2210-001 - Data Structures
// Assignment: Project 3
// Description: Defines the dock and how it is used in the simulation.
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project3
{
    public class Dock
    {
        public string Id { get; set; }
        public Queue<Truck> Line { get; }
        public double TotalSales { get; set; }
        public int TotalCrates { get; set; }
        public int TotalTrucks { get; set; }
        public int TimeInUse { get; set; }
        public int TimeNotInUse { get; set; }

        /// <summary>
        /// Constructor for the dock
        /// </summary>
        /// <param name="id">Docks unique Identification number</param>
        public Dock()
        {
            Id = GenerateId();
            Line = new Queue<Truck>();
        }
        /// <summary>
        /// Generates a random ID for the dock D-##
        /// </summary>
        /// <returns>Dock Id</returns>
        public string GenerateId()
        {
            Random random = new Random();
            string id = "D-" + random.Next(1, 16).ToString();
            return id;
        }
        /// <summary>
        /// Used in the simulation to join the line to unload at the dock.
        /// </summary>
        /// <param name="truck">A truck object derived from the truck class</param>
        public void JoinLine(Truck truck)
        {
            Line.Enqueue(truck);
        }

        /// <summary>
        /// Used in the simulation when the trucks leave the dock.
        /// </summary>
        /// <returns>Truck from the queue or null</returns>
        public Truck SendOff()
        {
            if (Line.Count > 0)
            {
                return Line.Dequeue();
            }
            else
            {
                return null; // Line is empty
            }
        }

    }
}
