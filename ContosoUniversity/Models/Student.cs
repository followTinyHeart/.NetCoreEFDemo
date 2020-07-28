using System;
using System.Collections.Generic;

namespace ContosoUniversity.Models
{
    public class Student
    {
        public int Id { get; set; }
        public String Guid { get; set; }
        public String LastName { get; set; }
        public String FirstName { get; set; }
        public DateTime EnrollmentDate { get; set; }
        public Boolean IsDelete { get; set; }
        public DateTime CreateTime { get; set; }

        public ICollection<Enrollment> Enrollments { get; set; }
    }
}
