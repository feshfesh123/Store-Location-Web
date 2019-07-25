using StoreInfo.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StoreInfo.Models
{
    public class StoreViewModel
    {
        public IEnumerable<Store> listStores { get; set; }
    }
}
