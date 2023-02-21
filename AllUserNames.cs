using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPTask6B
{
    internal class AllUserNames : List<UserName>
    {
        public AllUserNames()
        {
            Add(new UserName(1, "morning.star@edu.xamk.fi", "jane123#"));
            Add(new UserName(2, "shining.sun@edu.xamk.fi", "kate321&"));
            Add(new UserName(3, "money.talks@edu.xamk.fi", "joeJ765¤"));
            Add(new UserName(4, "success.story@edu.xamk.fi", "billMeLater8#"));
        }
        public List<Result> FindPassword(List<UserName> userGroup,
            List<Student> studentGroup, string sName)
        {
            //Local collection:
            List<Result> result = new List<Result>();

            var forgotten = from user in userGroup
                            join stu in studentGroup
                            on user.StudentId equals stu.Id
                            where stu.StudentName.Contains(sName)
                            select new
                            {
                                stu.StudentName,
                                user.Username,
                                user.Password
                            };
            if (forgotten.Count() > 0)
            {
                foreach (var item in forgotten)
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
