using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDM.Service.DTOs
{
    public class TaskPriorityDto
    {
        public int TaskPriorityId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime CreatedAt { get; set; }
        public int CreatedBy { get; set; }
        public DateTime UpdateAt { get; set; }
        public int UpdatedBy { get; set; }
    }
}
