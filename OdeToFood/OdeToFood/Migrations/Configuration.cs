using System.Collections.Generic;
using System.Data.Entity.Migrations;
using OdeToFood.Models;

namespace OdeToFood.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<OdeToFoodDb>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(OdeToFoodDb context)
        {
            context.Restaurants.AddOrUpdate(r => r.Name,
                new Restaurant {Name = "Sabatino's", City = "Baltimore", Country = "USA"},
                new Restaurant {Name = "Great Lake", City = "Chicago", Country = "USA"},
                new Restaurant
                {
                    Name = "Smaka",
                    City = "Gothemburg",
                    Country = "Sweden",
                    Reviews = new List<RestaurantReview>
                    {
                        new RestaurantReview
                        {
                            Rating = 9, Body = "Great Food!", ReviewerName = "Scott"
                        }
                    }
                });
        }
    }
}