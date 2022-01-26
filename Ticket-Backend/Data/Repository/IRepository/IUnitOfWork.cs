using System;
namespace Ticket_Backend.Data.Repository.IRepository
{
	public interface IUnitOfWork
	{
		ITicketRepository Ticket { get; }

		void save();
	}
}

