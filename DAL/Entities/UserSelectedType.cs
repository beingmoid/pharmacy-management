using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
  public  class UserSelectedType:BaseEntity
    {
        public int UserID { get; set; }
        public Users Users { get; set; }
        public int UserTypeID { get; set; }
        public UserType UserType { get; set; }

    }
}
