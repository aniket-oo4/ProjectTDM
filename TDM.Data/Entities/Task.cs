using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDM.Data.Entities
{
    public class Task
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string? StatusId { get; set; }
        public string? AssignedBy { get; set; }
        public DateTime? AssignedOn { get; set; }
        public DateTime? DueDate { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public int? PriorityId { get; set; }
        public int? CategoryId { get; set; }
        public int? ProjectId { get; set; }
        public int? UserId { get; set; }
        public string? TotalTimeSpent { get; set; }
        public string? UDF1 { get; set; }
        public string? UDF2 { get; set; }
        public string? UDF3 { get; set; }
        public string? UDF4 { get; set; }
        public string? UDF5 { get; set; }
    }

}
