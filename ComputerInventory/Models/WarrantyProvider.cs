using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerInventory.Models
{
    public partial class WarrantyProvider
    {
        public WarrantyProvider() {
            MachineWarranty = new HashSet<MachineWarranty>();
        }
        public int WarrantyProviderId { get; set; }
        public string ProviderName { get; set; }
        public int? SupportExtension { get; set; }
        public string SupportNumber { get; set; }
        public ICollection<MachineWarranty> MachineWarranty { get; set; }
    }
}
