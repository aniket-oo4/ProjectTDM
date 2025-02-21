using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDM.Data.Entities
{
    public class TaskType
    {
        public int TypeId { get; set; }
        public string TypeName { get; set; }
        public string TypeDescription { get; set; }
        public DateTime CreatedAt { get; set; }
        public int CreatedBy { get; set; }
        public DateTime UpdateAt { get; set; }
        public int UpdatedBy { get; set; }
    }
}
