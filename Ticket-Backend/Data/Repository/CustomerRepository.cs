using System;
using Ticket_Backend.models;

namespace Ticket_Backend.Data.Repository.IRepository
{
	public class CustomerRepository : Repository<Customer> , ICustomerRepository
	{
        private ApplicationDbContext _db;

        public CustomerRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(Customer obj)
        {
            var objFromDb = _db.Customers.FirstOrDefault(u => u.Id == obj.Id);
            if (objFromDb != null)
            {
                objFromDb.Name = obj.Name;
                objFromDb.Address = obj.Address;
                objFromDb.Tel = obj.Tel;
                objFromDb.Email = obj.Email;
    }
        }
    }
}

