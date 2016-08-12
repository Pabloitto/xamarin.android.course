using RaysTest.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaysTest.Core.Repository
{
    public class HotDogRepository
    {
        public static List<HotDogGroup> Groups
        {
            get
            {
                return new List<HotDogGroup>
                {
                    new HotDogGroup {
                        Id = 1,
                        ImagePath = "",
                        Title = "G1",
                        HotDogs = new List<HotDog>
                        {
                            new HotDog
                            {
                                Id = 1,
                                GroupName = "G1",
                                Name = "Regular Hot dog",
                                ImagePath = "HotDog",
                                ShortDescription = "Regular Hot dog",
                                Description = "Regular Hot dog",
                                Price = 50,
                                Ingredients = new List<string>
                                {
                                    "1",
                                    "2",
                                    "3"
                                }
                            }
                        }
                    },
                    new HotDogGroup {
                        Id = 1,
                        ImagePath = "",
                        Title = "G1",
                        HotDogs = new List<HotDog>
                        {
                            new HotDog
                            {
                                Id = 2,
                                GroupName = "G1",
                                Name = "Haute Hot dog",
                                ImagePath = "HotDog",
                                ShortDescription = "Haute Hot dog",
                                Description = "Haute Hot dog",
                                Price = 30,
                                Ingredients = new List<string>
                                {
                                    "1",
                                    "2",
                                    "3"
                                }
                            }
                        }
                    },
                    new HotDogGroup {
                        Id = 1,
                        ImagePath = "",
                        Title = "G1",
                        HotDogs = new List<HotDog>
                        {
                            new HotDog
                            {
                                Id = 3,
                                GroupName = "G1",
                                Name = "Extra Hot dog",
                                ImagePath = "HotDog",
                                ShortDescription = "Extra Hot dog",
                                Price = 35,
                                Description = "Extra Hot dog",
                                Ingredients = new List<string>
                                {
                                    "1",
                                    "2",
                                    "3"
                                }
                            }
                        }
                    },
                    new HotDogGroup {
                        Id = 1,
                        ImagePath = "",
                        Title = "G1",
                        HotDogs = new List<HotDog>
                        {
                            new HotDog
                            {
                                Id = 4,
                                GroupName = "G1",
                                Name = "Veggie Hot dog",
                                ImagePath = "HotDog",
                                ShortDescription = "Veggie Hot dog",
                                Description = "Veggie Hot dog",
                                Price = 40,
                                Ingredients = new List<string>
                                {
                                    "1",
                                    "2",
                                    "3"
                                }
                            }
                        }
                    },
                    new HotDogGroup {
                        Id = 1,
                        ImagePath = "",
                        Title = "G1",
                        HotDogs = new List<HotDog>
                        {
                            new HotDog
                            {
                                Id = 5,
                                GroupName = "G1",
                                Name = "Extra long Hot dog",
                                ImagePath = "HotDog",
                                ShortDescription = "Extra long Hot dog",
                                Description = "Extra long Hot dog",
                                Price = 100,
                                Ingredients = new List<string>
                                {
                                    "1",
                                    "2",
                                    "3"
                                }
                            }
                        }
                    }
                };
            }
        }
    }
}
