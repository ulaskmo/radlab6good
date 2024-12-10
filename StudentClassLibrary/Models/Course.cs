namespace StudentClassLibrary.Models
{
    public class Course
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }
        public string Lecturer { get; set; }
        public ICollection<Student> Students { get; set; }
    }
}