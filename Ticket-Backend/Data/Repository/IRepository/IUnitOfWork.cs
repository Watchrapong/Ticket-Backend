using System;
namespace Ticket_Backend.Data.Repository.IRepository
{
	public interface IUnitOfWork
	{
		ITicketRepository Ticket { get; }

		IUserRepository User { get; }

		ICustomerRepository Customer { get; }

		void save();
	}
}

