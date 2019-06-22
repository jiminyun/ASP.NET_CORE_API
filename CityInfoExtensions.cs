using CityInfo.API.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CityInfo.API
{
    public static class CityInfoExtensions
    {
        public static void EnsureSeedDataForContext(this CityInfoContext context)
        {
            if (context.Cities.Any())
            {
                return;
            }

            // init seed data
            var cities = new List<City>()
            {
                new City()
                {
                    Name = "New York City",
                    Description = "The one with that big park.",
                    PointsOfInterest = new List<PointOfInterest>()
                    {
                        new PointOfInterest()
                        {
                            Name = "Central Park1",
                            Description = "The most visited urban park in the USA"
                        },
                        new PointOfInterest()
                        {
                            Name = "Central Park2",
                            Description = "The most visited urban park in the USA"
                        }

                    }
                },
                new City()
                {
                    Name = "New York City2",
                    Description = "The one with that big park2.",
                    PointsOfInterest = new List<PointOfInterest>()
                    {
                        new PointOfInterest()
                        {
                            Name = "Empire State Building",
                            Description = "The most visited urban park in the USA"
                        }

                    }
                },
            };

            context.Cities.AddRange(cities);
            context.SaveChanges();
        }
    }
}
