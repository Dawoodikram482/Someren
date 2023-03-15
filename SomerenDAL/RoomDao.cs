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
            public List<room> GetAllRooms()
            {
                string query = "SELECT Id, Number, RoomType, BuildingType  FROM [Room]";
                SqlParameter[] sqlParameters = new SqlParameter[0];
                return ReadTables(ExecuteSelectQuery(query, sqlParameters));
            }

            private List<room> ReadTables(DataTable dataTable)
            {
                List<room> rooms = new List<room>();

                foreach (DataRow dr in dataTable.Rows)
                {
                    room Room = new room()
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

