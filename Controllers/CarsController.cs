using Microsoft.AspNetCore.Mvc;
using Shop.Data.Interfaces;
using Shop.Data.Models;
using Shop.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Controllers
{
    public class CarsController : Controller
    {
        private readonly IAllCars _allCars;
        private readonly ICarsCategory _allCatagories;

        public CarsController(IAllCars iAllCars, ICarsCategory iCarsCat)
        {
            _allCars = iAllCars;
            _allCatagories = iCarsCat;
        }

        [Route("Cars/List")]
        [Route("Cars/List/{category}")]
        public ViewResult List(string category)
        {
            string _category = category;
            IEnumerable<Car> cars = null;
            string currCategory = "";

            if (string.IsNullOrEmpty(category))
            {
                cars = _allCars.Cars.OrderBy(i => i.id);
            }
            else
            {
                if (string.Equals("electro", category, StringComparison.OrdinalIgnoreCase))
                {
                    cars = _allCars.Cars.Where(i => i.Category.categoryName.Equals("ElectroCars")).OrderBy(i => i.id);
                }
                else if (string.Equals("fuel", category, StringComparison.OrdinalIgnoreCase))
                {
                    cars = _allCars.Cars.Where(i => i.Category.categoryName.Equals("Classik Cars")).OrderBy(i => i.id);
                }

                currCategory = _category;
            }
            
            var carObj = new CarsListViewModels
            {
                allCars = cars,
                currCategory = currCategory
            };

            /*ViewBag.Category = "Some New";
            var cars = _allCars.Cars;
            return View(cars);*/


            /*CarsListViewModels obj = new CarsListViewModels();
            obj.allCars = _allCars.Cars;
            obj.currCategory = "CARS";*/

            ViewBag.Title = "CarShop";

            return View(carObj);
        }
    }
}
