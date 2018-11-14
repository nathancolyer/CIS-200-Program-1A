// Program 1A
// CIS 200-01
// Fall 2017
// Due: 9/25/2017
// By: C2518

// File: Package.cs
//  Package is a abstract derived class of base Parcel class.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog0
{
    public abstract class Package : Parcel
    {
        private const double packMin = 0; //Minimum measurement value for L,W,H,W

        // Backing fields for package:
        private double _length; //length
        private double _width; //width
        private double _height; //height
        private double _weight; //weight

        //Preconditions: Package dimensions and width have to be postive, >=0.
        //Postconditions: Package is created with specified values of origin and destination addresses, legnth, width, height, weight.
         public Package(Address originAddress, Address destAddress, double length, double width,
             double height, double weight): base(originAddress, destAddress)
        {
            Length = length;
            Width = width;
            Height = height;
            Weight = weight;
        }

        public double Length
        {
            //Precondition: None
            //Postcondition: Package length has been returned.
            get
            {
                return _length;
            }
            //Precondion: Length needs to be positive.
            //Postcondition: Length has been set to specified value.
            set
            {
                if (value >= packMin)
                    _length = value;
                else
                    throw new ArgumentOutOfRangeException("Length", value, "length must be positive");
            }
        }

        public double Width
        {
            //Precondition: None
            //Postcondition: Package width has been returned.
            get
            {
                return _width;
            }
            //Precondion: Width needs to be positive.
            //Postcondition: Width has been set to specified value.
            set
            {
                if (value >= packMin)
                    _width = value;
                else
                    throw new ArgumentOutOfRangeException("Width", value, "width must be positive");
            }
        }

        public double Height
        {
            //Precondition: None
            //Postcondition: Package height has been returned.
            get
            {
                return _height;
            }
            //Precondion: height needs to be positive.
            //Postcondition: height has been set to specified value.
            set
            {
                if (value >= packMin)
                    _height = value;
                else
                    throw new ArgumentOutOfRangeException("Height", value, "height must be positive");
            }
        }

        public double Weight
        {
            //Precondition: None
            //Postcondition: Package weight has been returned.
            get
            {
                return _weight;
            }
            //Precondion: Weight needs to be positive.
            //Postcondition: Weight has been set to specified value.
            set
            {
                if (value >= packMin)
                    _weight = value;
                else
                    throw new ArgumentOutOfRangeException("Weight", value, "weight must be positive");
            }
        }
        // Precondition:  None
        // Postcondition: A String with the package's data has been returned
        public override String ToString()
        {
            string NL = Environment.NewLine; //newline shortcut
            string result;  //builds formatted string

            result = $"{base.ToString()}{NL}{NL}Length:{Length}{NL}Width:{Width}{NL}Height:{Height}{NL}Weight:{Weight}";

            return result;
        }
    }
}
