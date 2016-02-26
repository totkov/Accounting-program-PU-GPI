using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tiamat.WindowsForms
{
    public class User
    {

        public User() { }
        public User(string user, string pass)
        {
            this.Username = user;
            this.Password = pass;
        }
        public User(string user, string pass, string email, string fname, string lname)
        {
            this.Username = user;
            this.Password = pass;
            this.Email = email;
            this.FirstName = fname;
            this.LastName = lname;
        }

        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
