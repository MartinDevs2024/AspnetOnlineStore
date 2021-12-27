using Microsoft.AspNetCore.Mvc;
using OrOnlineStore.DataAccess.Data;
using OrOnlineStore.Models;
using OrOnlineStore.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrOnlineStore.Areas.UI.Controllers
{
    [Area("UI")]
    public class MyMessagesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public MyMessagesController(ApplicationDbContext context)
        {
            _context = context;
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult New()
        {
            var viewModel = new MyMessagesViewModel();
            return View(viewModel);

        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] MyMessage mymessage)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            else
            {

                _context.MyMessages.Add(mymessage);
                await _context.SaveChangesAsync();
                return Json(new { IsSuccess = "redirect", description = Url.Action("Home", "Index", new { id = mymessage.Id }), mymessage });
            }
        }
    }
}
