using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class Supplier : BaseEntity
    {
        public Supplier()
        {
            this.Stock = new HashSet<Stock>();
        }
        public string SupplierName { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string Telephone { get; set; }
        public ICollection<Stock> Stock { get; set; }
    }
}
