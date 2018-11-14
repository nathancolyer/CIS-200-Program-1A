// Program 1A
// CIS 200-01
// Fall 2017
// Due: 9/25/2017
// By: C2518

// File: TwoDayAirPackage.cs
// TwoDayAirPackage is a concrete derived class of AirPackage class.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog0
{
    public class TwoDayAirPackage : AirPackage
    {
       public enum Delivery {Early,Saver}

        //Preconditions: L,W,H,WT >=0.
        //Postconditions: TwoDayAirPackage is created with the specified field values.
        public TwoDayAirPackage(Address originAddress, Address destAddress, double length, double width, double height,
            double weight, Delivery delivery) : base (originAddress, destAddress, length, width, height, weight)
        {
            DeliveryType = delivery;
        }

        //Precondition: None
        //Postcondition: Sets DeliveryType to specifed value.
        public Delivery DeliveryType
        {
            get;
            set;
        }
        //Preconditions: None
        //Postconditions: Returns cost of TwoDayAirPackage
        public override decimal CalcCost()
        {
            const double DIM_FACTOR = .25;
            const double WEIGHT_FACTOR = .25;
            const decimal REDUCED = .90m;
            decimal cost;

            cost = (decimal)(DIM_FACTOR * (Length + Width + Height) + WEIGHT_FACTOR * (Weight));

            if (DeliveryType == Delivery.Saver)
                cost *= REDUCED;

            return cost;
        }
        //Preconditions: None
        //Postconditions: Return a string that displays TwoNextDayAir package data.
        public override string ToString()
        {
            string result;
            string NL = Environment.NewLine;

            result = $"{base.ToString()}{NL}DeliveryType:{DeliveryType}";
            if (DeliveryType == Delivery.Saver)
                result += "\nSaver Discount: Yes";
            else
                result += "\nSaver Discount: No";

            return result;
        }

    }
}
