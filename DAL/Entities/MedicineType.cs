using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
   public class MedicineType : BaseEntity
    {
        public MedicineType()
        {
            this.Medicines = new HashSet<Medicine>();
        }
        public string MedicineTypeName { get; set; }
        public ICollection<Medicine> Medicines { get; set; }

    }
}
