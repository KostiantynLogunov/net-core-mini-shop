using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Shop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data
{
    public class DBObjects
    {
        public static void Initial(AppDBContent content)
        {                     

            if (!content.Category.Any())
            {
                content.Category.AddRange(Categories.Select(c => c.Value));
            }

            if (!content.Car.Any())
            {
                content.AddRange(
                    new Car
                    {
                        name = "Tesla Model S",
                        shortDesc = "a fast car",
                        longDesc = "nice, fast car Tesla",
                        img = "https://www.tesla.com/sites/tesla/files/curatedmedia/top%402.png",
                        price = 45000,
                        isFavorite = true,
                        available = true,
                        Category = Categories["ElectroCars"]
                    },
                        new Car
                        {
                            name = "Ford Fiesta",
                            shortDesc = "slowly car",
                            longDesc = "comfortable car for a city",
                            img = "https://i.infocar.ua/i/12/5128/1400x936.jpg",
                            price = 11000,
                            isFavorite = false,
                            available = true,
                            Category = Categories["Classik Cars"]
                        },
                        new Car
                        {
                            name = "BMW M3",
                            shortDesc = "fast car",
                            longDesc = "comfortable car for a city",
                            img = "https://upload.wikimedia.org/wikipedia/commons/thumb/f/f6/2018_BMW_M3_3.0.jpg/250px-2018_BMW_M3_3.0.jpg",
                            price = 65000,
                            isFavorite = true,
                            available = true,
                            Category = Categories["Classik Cars"]
                        },
                        new Car
                        {
                            name = "Mercedes c class",
                            shortDesc = "comfortable and big car",
                            longDesc = "comfortable car for a city",
                            img = "https://auto-arenda.ch/img/cars-img/mercedes--c-class-c43-amg-biturbo-4matic/mercedes--c-class-c43-amg-biturbo-4matic--5995a62e316c485410adabfdda61334d--640x480.jpg",
                            price = 40000,
                            isFavorite = false,
                            available = false,
                            Category = Categories["Classik Cars"]
                        },
                        new Car
                        {
                            name = "Nissan Leaf",
                            shortDesc = "without sound and ecology car",
                            longDesc = "comfortable car for a city",
                            img = "https://img.drive.ru/i/0/5ab4f18aec05c4697d00008c.jpg",
                            price = 14000,
                            isFavorite = true,
                            available = true,
                            Category = Categories["ElectroCars"]
                        }
                    );
            }

            content.SaveChanges();
        }

        private static Dictionary<string, Category> category;
        
        public static Dictionary<string, Category> Categories
        {
            get
            {
                if (category == null)
                {
                    var list = new Category[]
                    {
                        new Category{ categoryName = "ElectroCars", desc = "today kind f transport"},
                        new Category{ categoryName = "Classik Cars", desc = "Cars with DVS motor"}
                    };

                    category = new Dictionary<string, Category>();
                    
                    foreach (Category el in list)
                    {
                        category.Add(el.categoryName, el);
                    }
                }

                return category;
            }
        }
    }
}
