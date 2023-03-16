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
        private RoomDao roomDb;

        public RoomService()
        {
            roomDb = new RoomDao();
        }

        public List<Room> GetTeachers()
        {
            List<Room> rooms = roomDb.GetAllRooms();
            return rooms;
        }
    }
}
