using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerInventory.Models
{
    public partial class SupportTicket
    {
        public SupportTicket()
        {
            SupportLog = new HashSet<SupportLog>();
        }
        public int SupportTicketId { get; set; }
        public DateTime DateReported { get; set; }
        public DateTime? DateResolved { get; set; }
        public string IssueDescription { get; set; }
        public string IssueDetail { get; set; }
        public string TicketOpenedBy { get; set; }
        public int MachineId { get; set; }
        public Machine Machine { get; set; }
        public ICollection<SupportLog> SupportLog { get; set; }
    }
}