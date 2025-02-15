﻿using PokemonReviewApp.Data;
using PokemonReviewApp.Models;


namespace PokemonReviewApp
{
    public class Seed
    {
        private readonly DataContext dataContext;
        public Seed(DataContext context)
        {
            this.dataContext = context;
        }
        public void seedDataContext()
        {
            if (!dataContext.PokemonOwners.Any())
            {
                var pokemonOwners = new List<PokemonOwner>()
                {
                    new PokemonOwner()
                    {
                         Pokemon = new Pokemon()
                         {
                             Name = "Pikachu",
                             Birthdate = new DateTime(1903, 1, 1),
                             PokemonCategories = new List<PokemonCategory>()
                             {
                                 new PokemonCategory{ Category = new Category() { Name="electric"}}
                             },
                             Reviews = new List<Review>()
                             {
                                 new Review { Title = "Pikachu", Text = "Pikachu is the best pokemon", Rating = 1 ,
                                 Reviewer = new Reviewer() { FirstName = "Teddy", LastName = "Smith" } },

                                 new Review { Title = "Pikachu", Text = "Pikachu is the best a killing rocks", Rating = 1 ,
                                 Reviewer = new Reviewer() { FirstName = "Taylor", LastName = "Jones" } },

                                 new Review { Title = "Pikachu", Text = "Pikachu, pikachu, pikachu", Rating = 1 ,
                                 Reviewer = new Reviewer() { FirstName = "Jessica", LastName = "McGregor" } },
                             }

                         },
                         Owner = new Owner()
                         {
                             FirstName = "Jack",
                             LastName = "London",
                             Gym = "Brocks Gym",
                             Country = new Country()
                             {
                                 Name = "Kanto"
                             }

                         }
                    },
                     new PokemonOwner()
                     {
                         Pokemon = new Pokemon()
                         {
                             Name = "Squirtle",
                             Birthdate = new DateTime(1903, 1, 1),
                             PokemonCategories = new List<PokemonCategory>()
                             {
                                 new PokemonCategory { Category = new Category() { Name = "Water"} }
                             },
                             Reviews = new List<Review>()
                             {
                                 new Review { Title = "Squirtle", Text = "Squirtle is the best pokemon", Rating = 1 ,
                                 Reviewer = new Reviewer() { FirstName = "Teddy", LastName = "Smith" } },

                                 new Review { Title = "Squirtle", Text = "Squirtle is the best a killing rocks", Rating = 1 ,
                                 Reviewer = new Reviewer() { FirstName = "Taylor", LastName = "Jones" } },

                                 new Review { Title = "Squirtle", Text = "Squirtle, Squirtle, Squirtle", Rating = 1 ,
                                 Reviewer = new Reviewer() { FirstName = "Jessica", LastName = "McGregor" } },
                             }
                         },
                         Owner = new Owner()
                         {
                             FirstName = "Harry",
                             LastName = "Potter",
                             Gym = "Mistys Gym",
                             Country = new Country()
                             {
                                 Name = "Saffron City"
                             }

                         }
                     },
                     new PokemonOwner()
                     {
                         Pokemon = new Pokemon()
                         {
                             Name = "Venasuar",
                             Birthdate = new DateTime(1903, 1, 1),
                             PokemonCategories = new List<PokemonCategory>()
                             {
                                 new PokemonCategory { Category = new Category() { Name = "Leaf" } }
                             },
                             Reviews = new List<Review>()
                             {
                                 new Review { Title = "Venasuar", Text = "Venasuar is the best pokemon", Rating = 1,
                                     Reviewer = new Reviewer() { FirstName = "Teddy", LastName = "Smith" } },

                                 new Review { Title = "Venasuar", Text = "Venasuar is the best a killing rocks", Rating = 1,
                                     Reviewer = new Reviewer() { FirstName = "Taylor", LastName = "Jones" } },

                                 new Review { Title = "Venasuar", Text = "Venasuar, Venasuar, Venasuar", Rating = 1,
                                     Reviewer = new Reviewer() { FirstName = "Jessica", LastName = "McGregor" } },
                             }
                         },
                         Owner = new Owner()
                         {
                             FirstName = "Ash",
                             LastName = "Ketchum",
                             Gym = "Ashs Gym",
                             Country = new Country()
                             {
                                 Name = "Millet Town"
                             }
                         }
                     },

                };
                dataContext.PokemonOwners.AddRange(pokemonOwners);
                dataContext.SaveChanges();
            };
        }
    }
}
