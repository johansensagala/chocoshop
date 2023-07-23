using ChocoShop.Models;
using Microsoft.EntityFrameworkCore;
namespace ChocoShop.Data

{
    public static class ModelBuilderExtensions
    {
        public static ModelBuilder Seed(this ModelBuilder modelBuilder){
            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 1,
                    Name = "Snickers",
                    Description = "Snickers is a chocolate bar made by the American company Mars, Incorporated, consisting of nougat topped with caramel and peanuts that is encased in milk chocolate.",
                    Price = 73.000m,
                    ImageName = "Snickers.jpeg"
                },
                new Product
                {
                    Id = 2,
                    Name = "Milky Way",
                    Description = "Milky Way is a brand of chocolate-covered confectionery bar manufactured and marketed by Mars, Incorporated. The Milky Way bar is made of nougat, topped with caramel and covered with milk chocolate.",
                    Price = 30.000m,
                    ImageName = "Milkyway.jpg"
                },
                new Product
                {
                    Id = 3,
                    Name = "Bounty",
                    Description = "Bounty is a coconut-filled, chocolate-enrobed candy bar manufactured by Mars, Incorporated, introduced in 1951 in the United Kingdom and Canada. Bounty has a coconut filling, enrobed with milk chocolate (in a blue wrapper) or dark chocolate (in a red wrapper) and is usually sold as two small bars wrapped in one package.",
                    Price = 32.000m,
                    ImageName = "Bounty.jpg"
                },
                new Product
                {
                    Id = 4,
                    Name = "Mars",
                    Description = "Mars, commonly known as Mars bar, is the name of two varieties of chocolate bar produced by Mars, Incorporated. A delicious fusion of chocolate, caramel and nougat.",
                    Price = 13.000m,
                    ImageName = "Mars.jpg"
                },
                new Product
                {
                    Id = 5,
                    Name = "Twix",
                    Description = "Twix is a caramel shortbread chocolate bar made by Mars, Inc., consisting of a biscuit applied with other confectionery toppings and coatings (most frequently caramel and milk chocolate). Twix are packaged with one, two or four bars in a wrapper.",
                    Price = 17.000m,
                    ImageName = "Twix.jpg"
                },
                new Product
                {
                    Id = 6,
                    Name = "Kinder Maxi",
                    Description = "Kinder Maxi is a milk chocolate bar with a soft tasty milky filling that gives you the pleasure and taste of when you were a child.",
                    Price = 13.000m,
                    ImageName = "Kindermaxi.jpg"
                }
            );
            return modelBuilder;
        }
    }
}