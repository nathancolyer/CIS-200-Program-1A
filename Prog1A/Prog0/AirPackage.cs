// Program 1A
// CIS 200-01
// Fall 2017
// Due: 9/25/2017
// By: C2518

// File: AirPackage.cs
// AirPackage is a abstract derived class of Package class.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog0
{
    public abstract class AirPackage : Package
    {
        //Preconditions: Same as package, L,W,H,WT >=0
        //Postconditions: Air package is created with specifed values for origin address, dest address, L,W,H, and WT.
        public AirPackage(Address originAddress, Address destAddress, double length, double width,
             double height, double weight) : base(originAddress, destAddress, length, width, height, weight)
        {

        }
        //Preconditions: None
        //Postconditions: Returns true if air package is considered heavy, and false if not.
        public bool IsHeavy()
        {
            const double heavy = 75; //Package weight considered heavy in lbs.

            return (Weight >= heavy);

        }
        //Preconditions: None
        //Postconditions: Returns true if air package is considered large, and false if not.
        public bool IsLarge()
        {
            const double large = 100; //Package dimensions considered large

            return ((Length + Width + Height) >= large);
        }
        //Preconditions: None
        //Postconditions: Returns string of air package data
        public override string ToString()
        {
            string NL = Environment.NewLine;
            return $"{base.ToString()}{NL}Heavy status:{IsHeavy()}{NL}Large status:{IsLarge()}";
        }
    }
}
