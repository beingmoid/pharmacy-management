using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class Invoice : BaseEntity
    {
        public Invoice()
        {
            this.Sale = new HashSet<Sale>();
        }
        public DateTime? DateTime { get; set; }
        public ICollection<Sale> Sale { get; set; }
    }
}
