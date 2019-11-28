using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class UserType:BaseEntity
    {
        public UserType()
        {
            this.UserSelectedTypes = new HashSet<UserSelectedType>();
        }
        public string UserTypeName { get; set; }
        public ICollection<UserSelectedType> UserSelectedTypes { get; set; }

    }
}
