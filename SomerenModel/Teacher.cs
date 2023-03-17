namespace SomerenModel
{
    public class Teacher
    {
        public int Id { get; set; }     // database id
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; } // LecturerNumber, e.g. 47198
        public int Age { get; set; }
        public int RoomId { get; set; }
        public bool IsSuperviser { get; set; }

    }
}