using System;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Ticket_Backend.models
{
	public class Associate : BaseEntity
	{

		public int UserId { get; set; }

		public User User { get; set; }

		public int TicketId { get; set; }
		
		public Ticket Ticket { get; set; }

	}
}

