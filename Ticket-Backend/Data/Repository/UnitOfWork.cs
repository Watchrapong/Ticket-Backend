using System;
using Ticket_Backend.Data.Repository.IRepository;

namespace Ticket_Backend.Data.Repository
{
	public class UnitOfWork : IUnitOfWork
	{

        private ApplicationDbContext _db;

        public UnitOfWork(ApplicationDbContext db)
		{
            _db = db;
            Ticket = new TicketRepository(_db);
		}

        public ITicketRepository Ticket { get; private set; }

        public void save()
        {
            _db.SaveChanges();
        }
    }
}

