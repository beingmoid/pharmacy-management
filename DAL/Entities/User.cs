using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class Users:BaseEntity
    {
        public Users()
        {
            this.Sessions = new HashSet<Sessions>();
            this.UserRoles = new HashSet<UserRoles>();
            this.UserSelectedTypes = new HashSet<UserSelectedType>();
        }
        public string Firstname { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Telephone { get; set; }
        public bool Status { get; set; }
        public ICollection<Sessions> Sessions{ get; set; }
        public ICollection<UserRoles> UserRoles { get; set; }
        public ICollection<UserSelectedType> UserSelectedTypes { get; set; }
    }
}
