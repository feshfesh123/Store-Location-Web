using StoreInfo.Data;
using StoreInfo.Data.Interface;
using StoreInfo.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StoreInfo.Services
{
    public class StoreService : IStore
    {
        private readonly StoreInfoDbContext _ctx;
        public StoreService(StoreInfoDbContext ctx)
        {
            _ctx = ctx;
        }
        public IEnumerable<Store> GetAll()
        {
            return _ctx.Stores.ToList();
        }
    }
}
