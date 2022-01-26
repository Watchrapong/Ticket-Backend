using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ticket_Backend.models
{
	public class Ticket : BaseEntity
	{

		public int? UserId { get; set; }

		public User User { get; set; }

		public string Subject { get; set; }

		public string Description { get; set; }

		public int? CustomerId { get; set; }

        public Customer Customer { get; set; }

		public string Address { get; set; }

		public string Tel { get; set; }

		public string Email { get; set; }

		public int? EquipmentId { get; set; }

		public Equipment Equipment { get; set; }

		public string SerialNumber { get; set; }

		public string TicketType { get; set; }

		public TicketStatus TicketStatus { get; set; }

		public ICollection<Tasks> Tasks { get; set; }

		public ICollection<Associate> Associates { get; set; }

		public ICollection<TicketComment> TicketComments { get; set; }

		public ICollection<TicketStatusLog> TicketStatusLogs { get; set; }

	}
}

