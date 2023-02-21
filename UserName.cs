using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPTask6B
{
    internal class UserName
    {
        public UserName(int studentId, string username,
            string password)
        {
            StudentId = studentId;
            Username = username;
            Password = password;
        }

        public int StudentId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        //Instance methods:        
    }
}
