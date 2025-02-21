using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDM.Service.DTOs
{
    public class TaskUpdateDto
    {
        public int UpdateId { get; set; }
        public string Description { get; set; }
        public int TaskId { get; set; }
        public string SuggestedBy { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
