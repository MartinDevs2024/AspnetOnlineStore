using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrOnlineStore.Models.ViewModels
{
    public class RepairViewModel
    {
        public int Id { get; set; }
        public string RepairType { get; set; }

        public string Location { get; set; }

        public string Description { get; set; }

        public string AreaCover { get; set; }

        public string CurrentImage { get; set; }

        [Display(Name = "Please choose an image")]
        public IFormFile ImageUrl { get; set; }
    }
}
