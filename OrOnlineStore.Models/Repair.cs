using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrOnlineStore.Models
{
    public class Repair
    {
        [Key]
        public int Id { get; set; }
        public string RepairType { get; set; }

        public string Location { get; set; }

        public string Description { get; set; }

        public string AreaCover { get; set; }

        public string ImageUrl { get; set; }
    }
}
