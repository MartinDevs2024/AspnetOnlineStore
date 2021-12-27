using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using OrOnlineStore.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrOnlineStore.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = SD.Role_Admin)]
    public class PanelController : Controller
    {
        public IActionResult FrontPage()
        {
            return View();
        }
    }
}
