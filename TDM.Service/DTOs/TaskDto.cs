using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace TDM.Service.DTOs
{
    public class TaskDto
    {
        [JsonPropertyName("Id")]
        public int Id { get; set; }

        [JsonPropertyName("Name")]
        public String Name { get; set; }

        [JsonPropertyName("Description")]
        public String Description { get; set; }

        [JsonPropertyName("StatusId")]
        public String? StatusId { get; set; }

        [JsonPropertyName("AssignedBy")]
        public String? AssignedBy { get; set; }

        [JsonPropertyName("AssignedOn")]
        public DateTime? AssignedOn { get; set; }

        [JsonPropertyName("DueDate")]
        public DateTime? DueDate { get; set; }

        [JsonPropertyName("StartDate")]
        public DateTime  StartDate { get; set; }

        [JsonPropertyName("EndDate")]
        public DateTime EndDate { get; set; }

        [JsonPropertyName("CreatedBy")]
        public int? CreatedBy { get; set; }

        [JsonPropertyName("CreatedOn")]
        public DateTime CreatedOn { get; set; }

        [JsonPropertyName("UpdatedBy")]
        public int? UpdatedBy { get; set; }

        [JsonPropertyName("UpdatedOn")]
        public DateTime? UpdatedOn { get; set; }

        [JsonPropertyName("PriorityId")]
        public int? PriorityId { get; set; }

        [JsonPropertyName("CategoryId")]
        public int? CategoryId { get; set; }

        [JsonPropertyName("ProjectId")]
        public int? ProjectId { get; set; }

        [JsonPropertyName("UserId")]
        public int? UserId { get; set; }

        [JsonPropertyName("TotalTimeSpent")]
        public String? TotalTimeSpent { get; set; }

        [JsonPropertyName("UDF1")]
        public string? UDF1 { get; set; }

        [JsonPropertyName("UDF2")]
        public string? UDF2 { get; set; }

        [JsonPropertyName("UDF3")]
        public string? UDF3 { get; set; }

        [JsonPropertyName("UDF4")]
        public string? UDF4 { get; set; }

        [JsonPropertyName("UDF5")]
        public string? UDF5 { get; set; }

    }
}
