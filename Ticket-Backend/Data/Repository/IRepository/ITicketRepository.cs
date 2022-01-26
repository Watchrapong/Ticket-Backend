using System;
using Ticket_Backend.models;

namespace Ticket_Backend.Data.Repository.IRepository
{
	public interface ITicketRepository : IRepository<Ticket>
	{
		void Update(Ticket obj);
	}
}

