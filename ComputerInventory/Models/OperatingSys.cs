using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerInventory.Models
{
    public partial class OperatingSys
    {
        public OperatingSys() {
            Machine = new HashSet<Machine>();
        }

        public int OperatingSysId { get; set; }
        public string Name { get; set; }
        public bool StillSupported { get; set; }

        public ICollection<Machine> Machine { get; set; }
    }
}
