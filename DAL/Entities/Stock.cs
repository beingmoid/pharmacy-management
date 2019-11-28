using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class Stock : BaseEntity
    {

     
        public int MedicineId { get; set; }
        public Medicine Medicine { get; set; }
        public int SupplierId { get; set; }
        public Supplier Supplier { get; set; }
        public string StockName { get; set; }
        public DateTime? ExpiryDate { get; set; }

    }
}
