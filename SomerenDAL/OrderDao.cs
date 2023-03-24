using SomerenModel;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.IO;

namespace SomerenDAL
{
    public class OrderDao : BaseDao
    {
        public List<Order> GetAllOrders()
        {
            // selecting data from two different tables
            string query = "SELECT firstname, lastName FROM [STUDENT]" +
                           "SELECT drinkName, drinkType, price, stock FROM [DRINKS]";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<Order> ReadTables(DataTable dataTable)
        {
            List<Order> orders = new List<Order>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Order order = new Order()
                {
                    FirstName = dr["firstName"].ToString(),
                    LastName = dr["lastName"].ToString(),
                    DrinkName = dr["drinkName"].ToString(),
                    DrinkType = dr["drinkType"].ToString(),
                    Price = (int)dr["price"],
                    Stock = (int)dr["stock"],
                };
                orders.Add(order);
            }
            return orders;
        }

        public void PurchaseDrink(Order order)
        {
            string query = $"INSERT INTO Purchases (Order_id, Firstname, Lastname, drink_name, drink_type,price,stock,sales,Date_of_Purchase ) VALUES('{order.OrderId}', '{order.FirstName}', '{order.LastName}', '{order.DrinkName}', '{order.DrinkType}', '{order.Price}', '{order.Stock}', '{order.DateTime}');";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            ExecuteEditQuery(query, sqlParameters);
        }

    }
}
