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

    
        public class RoomDao : BaseDao
        {
            public List<Room> GetAllRooms()
            {

                 // obtains rooms from the database
                string query = "SELECT room_id, roomNumber, room_type, buildingtype  FROM [Rooms]";
                SqlParameter[] sqlParameters = new SqlParameter[0];
                return ReadTables(ExecuteSelectQuery(query, sqlParameters));
            }

            private List<Room> ReadTables(DataTable dataTable)
            {
              
                //makes a list of room and adds room data from database
                List<Room> rooms = new List<Room>();

                foreach (DataRow dr in dataTable.Rows)
                {
                    Room Room = new Room()
                    {
                        Id = (int)dr["room_id"],
                        Number =(int)dr["roomNumber"],
                        RoomType = (bool)dr["room_type"],
                        BuildingType = dr["buildingtype"].ToString(),
                    };
                    rooms.Add(Room);
                }
                return rooms;
            }
        }
    }


