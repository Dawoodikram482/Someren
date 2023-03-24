using SomerenDAL;
using SomerenModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenService
{
    public class VatCalcService
    {
        private VatCalcDao purchasesDb;

        public VatCalcService()
        {
            purchasesDb = new VatCalcDao();
        }

        public List<Order> GetPurchases()
        {
            List<Order> purchases = purchasesDb.GetAllPurchases();
            return purchases;
        }

    }
}
