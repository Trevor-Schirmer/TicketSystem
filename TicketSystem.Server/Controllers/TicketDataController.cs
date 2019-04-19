using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using TicketSystem.Shared;
using Microsoft.EntityFrameworkCore;
using TicketSystem.Server.DataAccess;

namespace TicketSystem.Server.Controllers
{



    public class TicketDataController : Controller
    {


        TicketDataAccessLayer objTicket = new TicketDataAccessLayer();


        [HttpGet]
        [Route("api/Ticket/GetAll")]
        public IEnumerable<Ticket> GetAll()
        {
            return objTicket.GetAllTickets();
        }











        //    [HttpGet("[action]")]
        //    public IEnumerable<Ticket> GetTickets()
        //    {
        //        List<Ticket> tickets = new List<Ticket>();

        //        try
        //        {
        //            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
        //            builder.DataSource = @"WIN10VMSQL\SQLEXPRESS";
        //            builder.UserID = "sa";
        //            builder.Password = "Lexington!";
        //            builder.InitialCatalog = "TicketSystem";

        //            using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
        //            {
        //                System.Diagnostics.Debug.WriteLine("\nQuery data example:");
        //                System.Diagnostics.Debug.WriteLine("=========================================\n");

        //                connection.Open();
        //                StringBuilder sb = new StringBuilder();
        //                sb.Append("SELECT * FROM [Tickets]");
        //                string sql = sb.ToString();

        //                using (SqlCommand command = new SqlCommand(sql, connection))
        //                {
        //                    using (SqlDataReader reader = command.ExecuteReader())
        //                    {
        //                        while (reader.Read())
        //                        {

        //                            Ticket ticket = new Ticket
        //                            {
        //                                TicketNo = Int32.Parse(reader["TicketNo"].ToString())
        //                            };
        //                            tickets.Add(ticket);
        //                        }
        //                    }
        //                }
        //            }
        //        }
        //        catch (SqlException e)
        //        {
        //            System.Diagnostics.Debug.WriteLine(e.ToString());
        //        }


        //        return tickets;

    //}




}
}
