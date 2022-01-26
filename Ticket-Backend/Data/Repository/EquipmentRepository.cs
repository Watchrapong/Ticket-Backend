using System;
using Ticket_Backend.Data.Repository.IRepository;
using Ticket_Backend.models;

namespace Ticket_Backend.Data.Repository
{
	public class EquipmentRepository : Repository<Equipment> , IEquipmentRepository
	{
        private ApplicationDbContext _db;

        public EquipmentRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(Equipment obj)
        {
            var objFromDb = _db.Equipments.FirstOrDefault(u => u.Id == obj.Id);
            if (objFromDb != null)
            {
                objFromDb.Name = obj.Name;
                objFromDb.SerialNumber = obj.SerialNumber;
                objFromDb.Model = obj.Model;
            }
        }
    }
}

