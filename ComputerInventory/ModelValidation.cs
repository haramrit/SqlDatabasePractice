using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ComputerInventory.Models;
using ComputerInventory.Data;

namespace ComputerInventory
{
    class ModelValidation
    {
        public ModelValidation()
        { }

        public bool ValidateSupportLog(SupportLog supportLog, string updateOrSave)
        {
            bool valid = true;
            if(updateOrSave.ToLower() == "update")
            {
                valid = SupportTicketIdExists(supportLog.SupportTicketId);
            }
            if (supportLog.SupportLogEntryDate < DateTime.Now.AddSeconds(-180))
            {
                valid = false;
            }
            if (supportLog.SupportLogEntry.Length < 10)
            {
                valid = false;
            }
            if (supportLog.SupportLogUpdatedBy.Length < 2)
            {
                valid = false;
            }
            return valid;
        }
        public bool SupportTicketIdExists(int supportTicketId)
        {
            bool exists = false;
            using (MachineContext context = new MachineContext())
            {
                exists = context.SupportTicket.Any(x => x.SupportTicketId.Equals(supportTicketId));
            }
            return exists;
        }
    }
}
