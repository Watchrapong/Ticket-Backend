using System;
using System.ComponentModel.DataAnnotations;

namespace Ticket_Backend.models
{
	public class Customer : BaseEntity
	{

		public string Name { get; set; }

		public string Address { get; set; }

		public string Tel { get; set; }

		public string Email { get; set; }

		public ICollection<Ticket> Tickets { get; set; }

		public ICollection<Equipment> Equipments { get; set; }
	}
}

