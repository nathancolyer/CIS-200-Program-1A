// Program 1A
// CIS 200-01
// Fall 2017
// Due: 9/25/2017
// By: C2518

// File: GroundPackage.cs
// GroundPackage is a concrete derived class of Package class.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog0
{
    public class GroundPackage : Package
    {
        //Preconditions: same as base class H,W,L,WT >=0
        //Postconditions:Ground Package is created with specified values for each.
        public GroundPackage(Address originAddress, Address destAddress, double length, double width, double height,
            double weight) : base(originAddress, destAddress, length, width, height, weight)
        {
            //Same as base class so no work needed
        }

        public int ZoneDistance
        {
            // Precondition:  None
            // Postcondition: The ground package's zone distance(postive of origin - dest) is returned.
            get
            {
                const int FIRST_DIGIT_FACTOR = 10000; // Denominator to get first digit
                int dist;  // Calculated postitive zone distance

                dist = Math.Abs((OriginAddress.Zip / FIRST_DIGIT_FACTOR) - (DestinationAddress.Zip / FIRST_DIGIT_FACTOR));

                return dist;
            }
        }
        // Precondition:  None
        // Postcondition: A GroundPackage cost has been returned.
        public override decimal CalcCost()
        {
            const double DIM_FACTOR = .2; //Used to calculate cost of dimensions
            const double WEIGHT_FACTOR = .05; //Used to calculator cost of weight
            decimal cost; // calculated cost to ship

            cost = (decimal)(DIM_FACTOR * (Length + Width + Height) + WEIGHT_FACTOR *(ZoneDistance+1)*(Weight));

            return cost;
        }
        // Precondition:  None
        // Postcondition: A String with the GroundPackage's data has been returned
        public override string ToString()
        {
            string result;
            string NL = Environment.NewLine;

            result = $"Ground Package{NL}{base.ToString()}{NL}Zone Distance:{ZoneDistance}";
            return result;
        }
    }
}


 

