
using System.Text.Json.Serialization;

namespace TDM.Service.DTOs
{
    public class TaskUpdateDto
    {
        [JsonPropertyName("update_id")]
        public int UpdateId { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }

        [JsonPropertyName("task_id")]
        public int TaskId { get; set; }

        [JsonPropertyName("suggested_by")]
        public string SuggestedBy { get; set; }

        [JsonPropertyName("updated_at")]
        public DateTime UpdatedAt { get; set; }
    }
}
