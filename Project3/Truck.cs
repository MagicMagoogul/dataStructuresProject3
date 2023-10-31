///////////////////////////////////////////////////////////////////////////////
//
// Author: Riley Owen, owenrm1@etsu.edu, Josh 
// Course: CSCI-2210-001 - Data Structures
// Assignment: Project 3
// Description:  
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project3
{
    /// <summary>
    /// Constructor for the trucks that bring the crates to the docks
    /// </summary>
    public class Truck
    {
        public string Driver { get; set; }
        public string DeliveryCompany { get; set; }
        public Stack<Crate> Trailer { get; }

        /// <summary>
        /// Constructor for the truck.
        /// </summary>
        /// <param name="driver"></param>
        /// <param name="deliveryCompany"></param>
        public Truck(string driver, string deliveryCompany)
        {
            Driver = driver;
            DeliveryCompany = deliveryCompany;
            Trailer = new Stack<Crate>();
        }


    }
}
