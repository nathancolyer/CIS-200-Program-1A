// Program 1A
// CIS 200-01
// Fall 2017
// Due: 9/25/2017
// By: C2518

// File: Program.cs
// Simple test program for initial Parcel classes build off of some already amazing code.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog0
{
    class Program
    {
        // Precondition:  None
        // Postcondition: Small list of Parcels is created and displayed
        static void Main(string[] args)
        {
            Address a1 = new Address("  John Smith  ", "   123 Any St.   ", "  Apt. 45 ", 
                "  Louisville   ", "  KY   ", 40202); // Test Address 1
            Address a2 = new Address("Jane Doe", "987 Main St.", 
                "Beverly Hills", "CA", 90210); // Test Address 2
            Address a3 = new Address("James Kirk", "654 Roddenberry Way", "Suite 321", 
                "El Paso", "TX", 79901); // Test Address 3
            Address a4 = new Address("John Crichton", "678 Pau Place", "Apt. 7",
                "Portland", "ME", 04101); // Test Address 4
            Address a5 = new Address("Bobby Lee", "8888 Ooga Booga Ally", "Memphis", "TN", 98963); //Test Address 5
            Address a6 = new Address("Jamie Oliver", "12 Healthy Cook Drive", "New York", "NY", 87455); //Test Address 6
            Address a7 = new Address("Gordon Ramsey", "2022 Raw Chicken Road", "Apt. 22 ", "Los Angeles", "CA", 94049);//Test Address 7
            Address a8 = new Address("Jon Snow", "1711 Winterfell Drive", "Winterfell", "WA", 45888); //Test Address 8

            Letter l1 = new Letter(a1, a3, 0.50M); // Test Letter 1
            Letter l2 = new Letter(a2, a4, 1.20M); // Test Letter 2
            Letter l3 = new Letter(a4, a1, 1.70M); // Test Letter 3
            GroundPackage gp1 = new GroundPackage(a1, a2, 10, 15, 20, 100); //Test groundpackage 1
            GroundPackage gp2 = new GroundPackage(a5, a8, 15, 16, 80, 10);//Test groundpackage 2
            GroundPackage gp3 = new GroundPackage(a6, a7, 15, 20, 25, 50);//Test groundpackage 3
            NextDayAirPackage nd1 = new NextDayAirPackage(a2, a4, 12, 14, 50, 100, 10.0M); //Test nextdayair 1
            NextDayAirPackage nd2 = new NextDayAirPackage(a1, a2, 100, 12, 30, 10, 15.0M);//Test nextdayair 2
            NextDayAirPackage nd3 = new NextDayAirPackage(a5, a7, 5, 5, 10, 20, 10.0m);//Test nextdayair 3
            TwoDayAirPackage td1 = new TwoDayAirPackage(a1, a2, 30, 30, 40, 10, TwoDayAirPackage.Delivery.Early); //test twodayair 1
            TwoDayAirPackage td2 = new TwoDayAirPackage(a3, a4, 10, 12, 14, 76, TwoDayAirPackage.Delivery.Saver); //test twodayair 2
            TwoDayAirPackage td3 = new TwoDayAirPackage(a4, a2, 10, 12, 45, 80, TwoDayAirPackage.Delivery.Saver); //test twodayair 3
            List<Parcel> parcels = new List<Parcel>(); // Test list of parcels

            // Add test data to list
            parcels.Add(l1);
            parcels.Add(l2);
            parcels.Add(l3);
            parcels.Add(gp1);
            parcels.Add(gp2);
            parcels.Add(gp3);
            parcels.Add(nd1);
            parcels.Add(nd2);
            parcels.Add(nd3);
            parcels.Add(td1);
            parcels.Add(td2);
            parcels.Add(td3);
            // Display data
            Console.WriteLine("Program 1A - List of Parcels\n");

            foreach (Parcel p in parcels)
            {
                Console.WriteLine(p);
                Console.WriteLine("--------------------");
            }

            var zipSort =
                from p in parcels
                orderby p.DestinationAddress.Zip descending 
                select p;

            if(zipSort.Any())
                foreach (var element in zipSort)
                {
                    Console.WriteLine($"{element}");
                }
            else
            {
                Console.WriteLine("No zip found");
            }

        
        }
    }
}
