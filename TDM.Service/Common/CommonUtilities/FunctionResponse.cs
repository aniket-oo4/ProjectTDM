using System.Net;

namespace TDM.Service.Common.CommonUtilities
{
    public class FunctionResponse<T>
    {
        public FunctionResponse()
        {
            ErrorList = new List<string>();
            Warnings = new List<string>();
        }

        // Status indicators
        public bool Success { get; set; }
        public HttpStatusCode HttpStatusCode { get; set; }
        public string Message { get; set; } // Informative messages (e.g., "Operation completed")

        // Data handling
        public T Data { get; set; } // Main result data
        public object AdditionalData { get; set; } // For auxiliary or related data
        public T GenericObject { get; set; } // Retained for flexibility

        // Error and warning handling
        public List<string> ErrorList { get; set; } // List of error messages
        public List<string> Warnings { get; set; } // List of warnings (non-critical)

        // Metadata
        public int ResultCount { get; set; } // Number of items in the current result
        public int TotalRecords { get; set; } // Total records for pagination scenarios
        public string CorrelationId { get; set; } // For tracing requests in distributed systems
        public DateTime Timestamp { get; set; } = DateTime.UtcNow; // Operation timestamp

        // Performance metrics
        public double ExecutionTimeInSeconds { get; set; } // Time taken for execution

        // Debugging information
        public string DebugInfo { get; set; } // Additional information for debugging (if needed)
    }

}