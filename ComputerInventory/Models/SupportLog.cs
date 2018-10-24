using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerInventory.Models
{
    public partial class SupportLog
    {
        public int SupportLogId { get; set; }
        public DateTime SupportLogEntryDate { get; set; }
        public string SupportLogEntry { get; set; }
        public string SupportLogUpdatedBy { get; set; }
        public int SupportTicketId { get; set; }
        public SupportTicket SupportTicket { get; set; }
    }
}