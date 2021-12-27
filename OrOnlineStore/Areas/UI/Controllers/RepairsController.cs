using Microsoft.AspNetCore.Mvc;
using OrOnlineStore.DataAccess.Repository.FileManager;
using OrOnlineStore.DataAccess.Repository.IRepository;
using OrOnlineStore.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrOnlineStore.Areas.UI.Controllers
{
    [Area("UI")]
    public class RepairsController : Controller
    {

        private readonly IRepairRepository _repo;
        private readonly IFileManager _fileManager;

        public RepairsController(IRepairRepository repo,
            IFileManager fileManager)
        {
            _repo = repo;
            _fileManager = fileManager;
        }
        public IActionResult Index()
        {
            var repairs = _repo.GetAllRepairs();
            if (User.IsInRole(SD.Role_Admin))
                return View("Index");
            else
                return View("ReadOnlyList", repairs);
        }

        public IActionResult Details(int id)
        {
            var repair = _repo.GetRepair(id);
            return View(repair);

        }

        #region API CALLS
        [HttpGet]
        public IActionResult GetAll()
        {
            var ObjFromDb = _repo.GetAllRepairs();
            return Json(new { data = ObjFromDb });
        }

        #endregion
    }
}
