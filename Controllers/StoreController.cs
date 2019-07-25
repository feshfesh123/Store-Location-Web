using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using StoreInfo.Data.Interface;
using StoreInfo.Models;

namespace StoreInfo.Controllers
{
    public class StoreController : Controller
    {
        private readonly IStore _storeService;
        public StoreController(IStore storeService)
        {
            _storeService = storeService;
        }
        public IActionResult Index()
        {
            var _listStores = _storeService.GetAll();
            var model = new StoreViewModel()
            {
                listStores = _listStores
            };
            return View(model);
        }
    }
}