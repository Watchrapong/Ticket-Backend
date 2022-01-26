using System;
using Ticket_Backend.Data.Repository.IRepository;
using Ticket_Backend.models;

namespace Ticket_Backend.Data.Repository
{
	public class UserRepository : Repository<User> , IUserRepository
	{
        private ApplicationDbContext _db;

        public UserRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }


        public void Update(User obj)
        {
            var objFromDb = _db.Users.FirstOrDefault(u => u.Id == obj.Id);
            if (objFromDb != null)
            {
                objFromDb.Name = obj.Name;
                objFromDb.Role = obj.Role;
                objFromDb.UserName = obj.UserName;
                objFromDb.Password = obj.Password;
                objFromDb.IsDelete = obj.IsDelete;
    }
        }
    }
}

