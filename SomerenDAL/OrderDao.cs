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
using System.Diagnostics;

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
                   
                    StudentId = (int)dr["student_id"],
                    DrinkId = (int)dr["drink_id"],
                    OrderDate = DateTime.Parse(dr["Date_of_Purchase"].ToString()),
                };
                orders.Add(order);
            }
            return orders;
        }

        public void OrderDrink(Order order)
        {
            string query = $"INSERT INTO [Order] (drink_id, student_id) VALUES('{order.DrinkId}', '{order.StudentId}');";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            ExecuteEditQuery(query, sqlParameters);
        }

    }
}
