using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerInventory.Models
{
    public partial class MachineWarranty
    {
        public int MachineWarrantyId { get; set; }
        public string ServiceTag { get; set; }
        public DateTime WarrantyExpiration { get; set; }
        public int MachineId { get; set; }
        public int WarrantyProviderId { get; set; }
        public WarrantyProvider WarrantyProvider { get; set; }
    }
}
