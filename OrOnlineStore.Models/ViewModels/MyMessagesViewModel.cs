using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrOnlineStore.Models.ViewModels
{
    public class MyMessagesViewModel
    { 
        [Key]  
        public int Id { get; set; }
        [Required]
        [Display(Name = "Please Enter Your Name")]
        public string Name { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [Phone]
        [Display(Name = "Please Enter Phone Number")]
        public string PhoneNumber { get; set; }
        [Required]
        [Display(Name = "Please A Messages")]
        public string Message { get; set; }

        public DateTime TimeSend { get; set; } = DateTime.Now;
    }
}
