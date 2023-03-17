using SomerenDAL;
using SomerenModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenService
{
    public class RoomService
    {
        private RoomDao roomdb;

        public RoomService()
        {
            roomdb = new RoomDao(); //creating new room DAO using database of room "roomdb"
        }

        public List<Room> GetRoom()
        {
            List<Room> Rooms = roomdb.GetAllRooms(); //"redirecting room into lists"
            return Rooms;
        }
    }
}
