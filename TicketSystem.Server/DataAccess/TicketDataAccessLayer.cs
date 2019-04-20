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

        public void AddTicket(Ticket ticket)
        {

                db.tblTickets.Add(ticket);
            

        }


        //To Update the records of a particluar ticket   
        public void UpdateTicket(Ticket ticket)
        {
            try
            {
                db.Entry(ticket).State = EntityState.Modified;
                db.SaveChanges();
            }
            catch
            {
                throw;
            }
        }

        //Get the details of a particular ticket   
        public Ticket GetTicketData(int id)
        {
            try
            {
                Ticket ticket = db.tblTickets.Find(id);
                return ticket;
            }
            catch
            {
                throw;
            }
        }

        //To Delete the record of a particular ticket   
        public void DeleteTicket(int id)
        {
            try
            {
                Ticket ticket = db.tblTickets.Find(id);
                db.tblTickets.Remove(ticket);
                db.SaveChanges();
            }
            catch
            {
                throw;
            }
        }



    }
}
