using System;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Ticket_Backend.models
{
	public class TicketComment: BaseEntity
	{
		public int TicketId { get; set; }

		public Ticket Ticket { get; set; }

		public string Message { get; set; }

		public string CreatedByUserId { get; set; }

	}
}

