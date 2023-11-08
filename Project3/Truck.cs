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
        
        public Truck()
        {
            Trailer = new Stack<Crate>();
            this.Driver = GenerateDriverNames();
            this.DeliveryCompany = GenerateCompanyNames();
        }
        /// <summary>
        /// Generates a random name for the Delivery Driver
        /// </summary>
        /// <returns>Name of Driver</returns>
        public string GenerateDriverNames()
        {
            Random random = new Random();
            string[] Names = {
                "Elijah",
                "Mason",
                "Liam",
                "Noah",
                "Oliver",
                "Aiden",
                "Carter",
                "Jackson",
                "Lucas",
                "William"
            };
            Driver = Names[random.Next(0, 10)];
            return Driver;
        }
        /// <summary>
        /// Generates a random name for the Delivery Company
        /// </summary>
        /// <returns>Delivery Company Name</returns>
        public string GenerateCompanyNames()
        {
            Random random = new Random();
            string[] CompanyNames =
            {
                "Amazon",
                "FedEx",
                "UPS",
                "DHL",
                "USPS",
            };
            DeliveryCompany = CompanyNames[random.Next(0, 6)];
            return DeliveryCompany;
        }
    }
}
