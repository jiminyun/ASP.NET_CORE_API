using CityInfo.API.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CityInfo.API.Models
{
    public class CitiesDataStore
    {
        public static CitiesDataStore Current { get; } = new CitiesDataStore();
        public List<CityDto> Cities { get; set; }

        public CitiesDataStore()
        {
            // init dummy data
            Cities = new List<CityDto>()
            {
                new CityDto()
                {
                    Id = 1,
                    Name = "New York City",
                    Description = "The one with that big park",
                    PointsOfInterest = new List<PointOfInterestDto>()
                    {
                        new PointOfInterestDto()
                        {
                            Id =1 ,
                            Name = "Central Park",
                            Description = "The most visited urban park i n the United State"
                        },
                        new PointOfInterestDto()
                        {
                            Id =2 ,
                            Name = "Central Park2",
                            Description = "The most visited urban park i n the United State2"
                        }
                    }

                },
                new CityDto()
                {
                    Id = 2,
                    Name = "New York City2",
                    Description = "The one with that big park",
                    PointsOfInterest = new List<PointOfInterestDto>()
                    {
                        new PointOfInterestDto()
                        {
                            Id =3 ,
                            Name = "Central Park3",
                            Description = "The most visited urban park i n the United State"
                        },
                        new PointOfInterestDto()
                        {
                            Id =4 ,
                            Name = "Central Park4",
                            Description = "The most visited urban park i n the United State2"
                        }
                    }
                },
                new CityDto()
                {
                    Id = 3,
                    Name = "New York City3",
                    Description = "The one with that big park",
                    PointsOfInterest = new List<PointOfInterestDto>()
                    {
                        new PointOfInterestDto()
                        {
                            Id =5 ,
                            Name = "Central Park5",
                            Description = "The most visited urban park i n the United State"
                        },
                        new PointOfInterestDto()
                        {
                            Id =64 ,
                            Name = "Central Park6",
                            Description = "The most visited urban park i n the United State2"
                        }
                    }
                }
            };
        }
    }
}
