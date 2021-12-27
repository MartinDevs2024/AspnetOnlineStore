using OrOnlineStore.DataAccess.Data;
using OrOnlineStore.DataAccess.Repository.IRepository;
using OrOnlineStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrOnlineStore.DataAccess.Repository
{
    public class RepairRepository : IRepairRepository
    {
        private readonly ApplicationDbContext _context;

        public RepairRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public void AddRepair(Repair repair)
        {
            _context.Add(repair);
        }

        public List<Repair> GetAllRepairs()
        {
            return _context.Repairs.ToList();
        }

        public Repair GetRepair(int id)
        {
            return _context.Repairs.FirstOrDefault(c => c.Id == id);
        }

        public void RemoveRepair(int id)
        {
            _context.Repairs.Remove(GetRepair(id));
        }
        public void UpdateRepair(Repair repair)
        {
            _context.Repairs.Update(repair);
        }

        public async Task<bool> SaveChangesAsync()
        {
            if (await _context.SaveChangesAsync() > 0)
            {
                return true;
            }
            return false;
        }

    }
}
