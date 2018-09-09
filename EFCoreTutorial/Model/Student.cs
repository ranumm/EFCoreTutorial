using System;
using System.Collections.Generic;
using System.Text;

namespace EFCoreTutorial.Model
{
    public class Student
    {
        public int StudentId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime EnrollmentDate { get; set; }
    }
}
