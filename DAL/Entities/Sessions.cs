using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
   public class Sessions:BaseEntity
    {
        public int UserID { get; set; }
        public Users User{ get; set; }
        public DateTime TimeLoggedIn { get; set; }

    }
}
