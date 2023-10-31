using AutoMapper;

namespace StudentAPI.Entity
{
    public class Student
    {

        public Student() 
        {
        }
        public int StudentID { get; set; }
        public string Name { get; set; } = "";

        public int ContactNumber { get; set; }

        public int Age { get; set; }

    }
}
