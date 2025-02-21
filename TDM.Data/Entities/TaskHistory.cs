using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDM.Data.Entities
{
    public class TaskHistory
    {
        public int HistoryId { get; set; }
        public int TaskId { get; set; }
        public int ChangedBy { get; set; }
        public string ChangeDescription { get; set; }
        public DateTime ChangedAt { get; set; }
    }
}
