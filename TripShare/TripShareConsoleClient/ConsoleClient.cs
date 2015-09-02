﻿using System;
using System.Linq;
using TripShare.Data;
using TripShare.Models;

namespace TripShareConsoleClient
{
    class ConsoleClient
    {
        static void Main()
        {
            var context = new TripShareDbContext();

            var cities = context.Cities
                .Select(c => c.CityName)
                .ToList();

            foreach (var city in cities)
            {
                Console.WriteLine(city);
            }
        }
    }
}
