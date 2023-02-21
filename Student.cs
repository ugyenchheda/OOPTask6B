using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPTask6B
{
    internal class Student
    {
        public Student(int id, string studentName)
        {
            Id = id;
            StudentName = studentName;
        }

        public int Id { get; set; }
        public string StudentName { get; set; }
    }
}
