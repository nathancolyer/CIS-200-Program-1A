// Program 1A
// CIS 200-01
// Fall 2017
// Due: 9/25/2017
// By: C2518

// File: NextDayAirPackage.cs
// NextDayAirPackage is a concrete derived class of AirPackage class.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog0
{
    public class NextDayAirPackage : AirPackage
    {

        private decimal _expressFee; //express fee backing field

        //Preconditions: Same as base class L,W,H,WT >=0
        //Postconditions: Next day air package is created with fields of the parameter
        public NextDayAirPackage(Address originAddress, Address destAddress, double length, double width,
             double height, double weight, decimal expressFee) : base(originAddress, destAddress, length, width, height, weight)
        {
            ExpressFee = expressFee;
        }
   
        public decimal ExpressFee
        {
            //Preconditions: None
            //Postconditions: Express fee is returned for NextDayAir
            get
            {
                return _expressFee;
            }
            //Preconditions: value >=0
            //Postconditions: Sets NextDayAir expree fee to specified value.
            private set
            {
                const decimal feeMin = 0m;

                if (value >= feeMin)
                    _expressFee = value;
                else
                    throw new ArgumentOutOfRangeException("Express fee", value, "express fee must be >=0)");
            }
        }
        //Preconditions: None
        //Postconditions: Returns the cost of NextDairAirPackage
        public override decimal CalcCost()
        {
            const double DIM_FACTOR = .40; //base dimensions factor
            const double WEIGHT_FACTOR = .30; //base weight factor
            const double HEAVY_FACTOR = .25; //heavy package factor
            const double LARGE_FACTOR = .25; //large package factor
            decimal cost; //total cost of package

            cost = (decimal)(DIM_FACTOR * (Length + Width + Height) + WEIGHT_FACTOR * (Weight)) + (ExpressFee);

            if (IsHeavy())
                cost += (decimal)(HEAVY_FACTOR * (Weight));
            if (IsLarge())
                cost += (decimal)(LARGE_FACTOR * (Length + Width + Height));
            return cost;
        }
        //Preconditions: None
        //Postconditions: Return a string that displays NextDayAir package data.
        public override string ToString()
        {
            string result;
            string NL = Environment.NewLine;

            result = $"NextDayAir Package{NL}{base.ToString()}{NL}Express Fee:{ExpressFee:c}";
            return result;
        }
    }
}
