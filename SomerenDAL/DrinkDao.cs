using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SomerenModel;

namespace SomerenDAL
{
   public class DrinkDao : BaseDao
    {
        public List<Drinks> GetAllDrinks()
        {
            string query = "select drink_id ,  vat, stock, drink_name , drink_type , price\r\nfrom [dbo].[Drinks]\r\norder by  drink_name ";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<Drinks> ReadTables(DataTable dataTable)
        {
            List<Drinks> drinks = new List<Drinks>();

            foreach (DataRow dr in dataTable.Rows)
            {
               Drinks drink = new Drinks()
                {
                    drinkID = (int)dr["drink_id"],
                    drinkName = dr["drink_name"].ToString(),
                    drinkType = dr["drink_type"].ToString(),
                    drinkPrice = (int)dr["price"],
                    drinkStock = (int)dr["stock"],
                    //drinkSold = dr["sales"].ToString()

                };
               drinks.Add(drink);
            }
            return drinks;
        }
    }
}
