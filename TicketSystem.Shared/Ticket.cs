using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;


namespace TicketSystem.Shared
{
    public class Ticket
    {
        [Key][Required]
        public int TicketNo { get; set; }       

        public DateTime DateCreated { get; set; }

        public string CreatedBy { get; set; }

        public string Status { get; set; }

        public string AssignedTo { get; set; }

        public string LastUpdated { get; set; }

        public string Category { get; set; }

        public DateTime DueDate { get; set; }

        public string Priority { get; set; }

        public string Merged { get; set; }

    }
}
