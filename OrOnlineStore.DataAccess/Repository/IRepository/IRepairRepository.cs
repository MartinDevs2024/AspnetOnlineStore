using OrOnlineStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrOnlineStore.DataAccess.Repository.IRepository
{
    public interface IRepairRepository
    {
        Repair GetRepair(int id);
        List<Repair> GetAllRepairs();
        void AddRepair(Repair repair);
        void UpdateRepair(Repair repair);
        void RemoveRepair(int id);
        Task<bool> SaveChangesAsync();

    }
}
