using SomerenModel;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;

namespace SomerenDAL
{
    public class VatCalcDao: BaseDao
    {
        public List<Order> GetAllPurchases()
        {

            // obtains buys from the database
            string query = "SELECT Order_id, drink_type, price, Date_of_Purchase FROM [Cash Register]";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }
        private List<Order> ReadTables(DataTable dataTable)
        {

            //makes a list of buys and adds buy data from database
            List<Order> rooms = new List<Order>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Order Room = new Order()
                {
                    OrderId = (int)dr["Order_id"],
                    DrinkType = dr["drink_type"].ToString(),
                    DateTime = DateTime.Parse(dr["Date_of_Purchase"].ToString()),
                    Price = (int)dr["price"]
                };
                rooms.Add(Room);
            }
            return rooms;
        }

    }
}
