using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using OrOnlineStore.DataAccess.Repository.FileManager;
using OrOnlineStore.DataAccess.Repository.IRepository;
using OrOnlineStore.Models.ViewModels;
using OrOnlineStore.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrOnlineStore.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = SD.Role_Admin)]
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
            return View();
        }

        [HttpGet]
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return View(new RepairViewModel());
            }
            else
            {
                var repair = _repo.GetRepair((int)id);
                return View(new RepairViewModel
                {
                    Id = repair.Id,
                    RepairType = repair.RepairType,
                    Location = repair.Location,
                    Description = repair.Description,
                    AreaCover = repair.AreaCover,
                    CurrentImage = repair.ImageUrl

                });
            }
        }

        [HttpPost]
        public async Task<IActionResult> Edit(RepairViewModel vm)
        {
            var repair = new Models.Repair
            {
                Id = vm.Id,
                RepairType = vm.RepairType,
                Location = vm.Location,
                AreaCover = vm.AreaCover,
                Description = vm.Description
            };
            if (vm.ImageUrl == null)
            {
                repair.ImageUrl = vm.CurrentImage;
            }
            else
            {
                repair.ImageUrl = await _fileManager.SaveImage(vm.ImageUrl);
            }
            if (repair.Id > 0)
            {
                _repo.UpdateRepair(repair);
            }
            else
                _repo.AddRepair(repair);
            if (await _repo.SaveChangesAsync())
                return RedirectToAction("Index");
            else
                return View(repair);
        }


        [HttpGet("/RepairImageUrl/{repairImageUrl}")]
        [ResponseCache(CacheProfileName = "Monthly")]
        public IActionResult RepairImageUrl(string repairImageUrl)
        {
            var mine = repairImageUrl.Substring(repairImageUrl.LastIndexOf('.') + 1);
            return new FileStreamResult(_fileManager.ImageStream(repairImageUrl), $"repairImageUrl/{mine}");
        }
    }
}
