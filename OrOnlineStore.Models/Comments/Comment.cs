using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrOnlineStore.Models.Comments
{
    public class Comment
    {
        public int Id { get; set; }

        public string Message { get; set; }

        public DateTime Created { get; set; }
    }
}
