using System;
using Ticket_Backend.models;

namespace Ticket_Backend.Data.Repository.IRepository
{
	public interface ICustomerRepository : IRepository<Customer>
	{
		void Update(Customer obj);
	}
}

