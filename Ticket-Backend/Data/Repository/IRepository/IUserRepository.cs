using System;
using Ticket_Backend.models;

namespace Ticket_Backend.Data.Repository.IRepository
{
	public interface IUserRepository : IRepository<User>
	{
		void Update(User obj);
	}
}

