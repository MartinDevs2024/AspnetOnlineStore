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
    public class OrderDetailsRepository : Repository<OrderDetail>, IOrderDetailsRepository
    {
        private readonly ApplicationDbContext _db;

        public OrderDetailsRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }


        public void Update(OrderDetail obj)
        {
            _db.Update(obj);
        }
    }
}
