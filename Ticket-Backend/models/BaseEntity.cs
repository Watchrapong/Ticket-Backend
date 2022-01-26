using System;
namespace Ticket_Backend.models
{
	public class BaseEntity
    {
        public int Id { get; set; }

        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}

