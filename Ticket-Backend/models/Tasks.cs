using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ticket_Backend.models
{
    public class Tasks : BaseEntity
    {

        public int TicketId { get; set; }

        public Ticket Ticket { get; set; }

        public string Description { get; set; }

        public string WorkLog { get; set; }

    }
}

