using System;
using Ticket_Backend.models;

namespace Ticket_Backend.Data.Repository.IRepository
{
	public interface IEquipmentRepository : IRepository<Equipment>
	{
		void Update(Equipment obj);
	}
}

