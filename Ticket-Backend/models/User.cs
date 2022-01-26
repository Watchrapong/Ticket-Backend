using System;
using System.ComponentModel.DataAnnotations;

namespace Ticket_Backend.models
{
	public class User:BaseEntity
	{
		public int UserId { get; set; }

		public string Name { get; set; }

		public string Role { get; set; }

		public string UserName { get; set; }

		public string Password { get; set; }

		public bool IsDelete { get; set; }

		public ICollection<Associate> Associates { get; set; }

		public ICollection<Ticket> Tickets { get; set; }

		//public ICollection<TicketStatusLog> TicketStatusLogs { get; set; }
	}
}

