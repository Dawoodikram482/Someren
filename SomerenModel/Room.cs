namespace SomerenModel
{
    public class Room
    {
        public int Id { get; set; }         // database id
        public int Number { get; set; }     // RoomNumber, e.g. 206
        public int Capacity { get; set; }   // number of beds, either 4, 6, 8, 12 or 16
        public bool RoomType { get; set; }      // student = false, teacher = true
        public string BuildingType { get; set; } // buidling type A and B

    }
}