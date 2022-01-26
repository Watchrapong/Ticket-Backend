using System;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Ticket_Backend.models
{
    public class TicketStatusLog : BaseEntity
    {
        public int TicketId { get; set; }

        public Ticket Ticket { get; set; }

        public TicketStatus TicketStatus { get; set; }

        public int? UserId { get; set; }

        public User User { get; set; }

    }

}

