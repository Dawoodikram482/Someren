using SomerenDAL;
using SomerenModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenService
{
    public class DrinkService
    {
        private DrinkDao drinkDb;

        public DrinkService()
        {
           drinkDb = new DrinkDao();
        }

        public List<Drinks> GetDrinks()
        {
            List<Drinks> drinks = drinkDb.GetAllDrinks();
            return drinks;
        }
    }
}
