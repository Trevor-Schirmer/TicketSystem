using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TicketSystem.Shared;

namespace TicketSystem.Server.DataAccess
{
    public class TicketDataAccessLayer
    {
        TicketContext db = new TicketContext();

        public IEnumerable<Ticket> GetAllTickets()
        {
            try
            {
                return db.tblTickets.ToList();
            }
            catch
            {
                throw;
            }
        }

    }
}
