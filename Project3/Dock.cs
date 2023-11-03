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

        public Dock(string id)
        {
            Id = id;
            Line = new Queue<Truck>();
        }

        /// <summary>
        /// Used in the simulation to join the line to unload at the dock.
        /// </summary>
        /// <param name="truck"></param>
        public void JoinLine(Truck truck)
        {
            Line.Enqueue(truck);
        }

        public void UnloadCrate()
        {
            if (Line.Peek() == null)
            {
                TimeNotInUse++;
                return;
            }

            TotalSales += Line.Peek().Trailer.Pop().GetPrice();
            TotalCrates++;

            if (Line.Peek().Trailer.Count ==0)
            {
                this.SendOff();
            }
        }

        /// <summary>
        /// Used in the simulation when the trucks leave the dock.
        /// </summary>
        /// <returns></returns>
        public Truck SendOff()
        {
            if (Line.Count > 0)
            {
                TotalTrucks++;
                return Line.Dequeue();
            }
            else
            {
                return null; // Line is empty
            }
        }
    }
}
