using Shop.Data.Interfaces;
using Shop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data.Mocks
{
    public class CarsRepository : IAllCars
    {
        private readonly ICarsCategory _categoryCars = new MockCatagory();

        public IEnumerable<Car> Cars 
        {
            get
            {
                return new List<Car>
                    {
                        new Car{
                            name = "Tesla Model S",
                            shortDesc = "a fast car", 
                            longDesc = "nice, fast car Tesla", 
                            img = "https://www.tesla.com/sites/tesla/files/curatedmedia/top%402.png", 
                            price = 45000, 
                            isFavorite = true, 
                            available = true,
                            Category = _categoryCars.AllCategories.First()
                        },
                        new Car{
                            name = "Ford Fiesta",
                            shortDesc = "slowly car",
                            longDesc = "comfortable car for a city",
                            img = "https://i.infocar.ua/i/12/5128/1400x936.jpg",
                            price = 11000,
                            isFavorite = false,
                            available = true,
                            Category = _categoryCars.AllCategories.Last()
                        },
                        new Car{
                            name = "BMW M3",
                            shortDesc = "fast car",
                            longDesc = "comfortable car for a city",
                            img = "https://upload.wikimedia.org/wikipedia/commons/thumb/f/f6/2018_BMW_M3_3.0.jpg/250px-2018_BMW_M3_3.0.jpg",
                            price = 65000,
                            isFavorite = true,
                            available = true,
                            Category = _categoryCars.AllCategories.Last()
                        },
                        new Car{
                            name = "Mercedes c class",
                            shortDesc = "comfortable and big car",
                            longDesc = "comfortable car for a city",
                            img = "https://auto-arenda.ch/img/cars-img/mercedes--c-class-c43-amg-biturbo-4matic/mercedes--c-class-c43-amg-biturbo-4matic--5995a62e316c485410adabfdda61334d--640x480.jpg",
                            price = 40000,
                            isFavorite = false,
                            available = false,
                            Category = _categoryCars.AllCategories.Last()
                        },
                        new Car{
                            name = "Nissan Leaf",
                            shortDesc = "without sound and ecology car",
                            longDesc = "comfortable car for a city",
                            img = "https://img.drive.ru/i/0/5ab4f18aec05c4697d00008c.jpg",
                            price = 14000,
                            isFavorite = true,
                            available = true,
                            Category = _categoryCars.AllCategories.First()
                        }

                    };
            }
        }
        
        public IEnumerable<Car> getFavCars { get; set; }

        public Car getObjectCar(int carId)
        {
            throw new NotImplementedException();
        }
    }
}
