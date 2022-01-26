using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ticket_Backend.models
{
	public class Equipment: BaseEntity
	{

		public int CustomerId { get; set; }

        public Customer Customer { get; set; }

		public string Name { get; set; }

		public string SerialNumber { get; set; }

		public string Model { get; set; }

		public ICollection<Ticket> Tickets { get; set; }
	}
}

