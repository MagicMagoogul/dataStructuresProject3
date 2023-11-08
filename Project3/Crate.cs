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
    /// The class for the crates that go into the trucks
    /// </summary>
    public class Crate
    {
        string Id { get; set; } //The crates unique identification number
        double Price { get; set; }  //The cost of the crates contents

        /// <summary>
        /// Constructor for the crate class
        /// </summary>
        public Crate()
        {
           this.Id = GenerateId();
           this.Price = GeneratePrice();
        }

        /// <summary>
        /// creates the price of the crate 50-500
        /// </summary>
        /// <returns>price of crate</returns>
        public double GeneratePrice()
        {
            Random random = new Random();
            double price = random.Next(50, 501);
            return price;
        }
        /// <summary>
        /// Generates a random ID for the crate C-####
        /// </summary>
        /// <returns>id of crate</returns>
        public string GenerateId()
        {
            Random random = new Random();
            string id = "C-" + random.Next(1000, 9999).ToString();
            return id;
        }
    }
}
