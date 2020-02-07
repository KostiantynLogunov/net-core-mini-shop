using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Shop.Data.Interfaces;
using Shop.Data.Models;

namespace Shop.Data.Mocks
{
    public class MockCatagory : ICarsCategory
    {
        public IEnumerable<Category> AllCategories
        {
            get
            {
                return new List<Category>
                    {
                        new Category{ categoryName = "ElectroCars", desc = "today kind f transport"},
                        new Category{ categoryName = "Classik Cars", desc = "Cars with DVS motor"}
                    };
            }
        }
    }
}
