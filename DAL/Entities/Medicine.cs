using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
   public class Medicine : BaseEntity
    {
        public Medicine()
        {
            this.Stock = new HashSet<Stock>();
            this.Sale = new HashSet<Sale>();
        }
        public int MedicineTypeId { get; set; }
        public MedicineType MedicineType { get; set; }
        public string MedicienceName { get; set; }
        public ICollection<Stock> Stock { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public ICollection<Sale> Sale { get; set; }

    }
}
