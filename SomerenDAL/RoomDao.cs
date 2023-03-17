using SomerenModel;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenDAL
{
    public class RoomDao: BaseDao
    {
        public List<Room> GetAllRooms()
        {
            string query = "SELECT Number, Capacity, Type FROM Rooms";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }
        private List<Room> ReadTables(DataTable dataTable)
        {
            List<Room> Rooms = new List<Room>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Room Room = new Room()
                {
                    Number = (int)dr["Number"],
                    Capacity =(int) dr["Capacity"],
                    Type = (bool)dr["Type"]
                };
                Rooms.Add(Room);
            }
            return Rooms;
        }
    }
}
