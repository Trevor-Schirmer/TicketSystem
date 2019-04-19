using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using TicketSystem.Shared;

namespace TicketSystem.Server.DataAccess
{
    public class TicketContext : DbContext
    {
        public virtual DbSet<Ticket> tblTickets { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
                builder.DataSource = @"WIN10VMSQL\SQLEXPRESS";
                builder.UserID = "sa";
                builder.Password = "Lexington!";
                builder.InitialCatalog = "TicketSystem";

                optionsBuilder.UseSqlServer(builder.ToString());
            }
        }
    }
}
