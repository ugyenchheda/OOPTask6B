using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPTask6B
{
    internal class AllStudents : List<Student>
    {
        public AllStudents()
        {
            Add(new Student(1, "Jane"));
            Add(new Student(2, "Kate"));
            Add(new Student(3, "Joe"));
            Add(new Student(4, "Bill"));
        }
        public List<Result> FindStudent(List<UserName> userGroup,
            List<Student> studentGroup, string sUsername)
        {
            //Local collection:
            List<Result> result = new List<Result>();

            var studentInfo = from user in userGroup
                              join stu in studentGroup
                              on user.StudentId equals stu.Id
                              where user.Username.Contains(sUsername)
                              select new
                              {
                                  stu.StudentName,
                                  user.Username,
                                  user.Password
                              };
            if (studentInfo.Count() > 0)
            {
                foreach (var item in studentInfo)
                {
                    result.Add(new Result(item.StudentName, item.Username, item.Password));
                }
                return result;
            }
            else
                return result;
        }
    }
}
