using System;
using Ticket_Backend.Data.Repository.IRepository;
using Ticket_Backend.models;

namespace Ticket_Backend.Data.Repository
{
    public class TicketRepository : Repository<Ticket>, ITicketRepository
    {

        private ApplicationDbContext _db;

        public ProductRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(Ticket obj)
        {
            var objFromDb = _db.Tickets.FirstOrDefault(u => u.Id == obj.Id);
            if (objFromDb != null)
            {
                objFromDb.UserId = obj.UserId;
                objFromDb.Subject = obj.Subject;
                objFromDb.SerialNumber = obj.SerialNumber;
                objFromDb.Tasks = obj.Tasks;
                objFromDb.Description = obj.Description;
                objFromDb.Address = obj.Address;
                objFromDb.Tel = obj.Tel;
                objFromDb.TicketComments = obj.TicketComments;
                objFromDb.TicketType = obj.TicketType;
                objFromDb.Description = obj.Description;
                objFromDb.CustomerId = obj.CustomerId;
                objFromDb.Email = obj.Email;
                objFromDb.EquipmentId = obj.EquipmentId;
                objFromDb.TicketStatus = obj.TicketStatus;
            }
        }
    }
}

