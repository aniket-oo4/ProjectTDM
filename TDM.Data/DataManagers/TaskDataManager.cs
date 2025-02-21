using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using TDM.Data.Entities;
namespace TDM.Data.DataManagers
{
    internal class TaskDataManager
    {
        private string _connectionString;

        public UserTask LoadTask(int taskId)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                //var query = "SELECT * FROM Tasks WHERE Id = @TaskId";
                var query = "SELECT Id, Name, Description, StatusId, AssignedBy, AssignedOn, DueDate, StartDate, EndDate, CreatedBy, CreatedOn, UpdatedBy, UpdatedOn, PriorityId, CategoryId, ProjectId, UserId, TotalTimeSpent, UDF1, UDF2, UDF3, UDF4, UDF5 FROM Tasks WHERE Id = @TaskId";
                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@TaskId", taskId);
                    using (var adapter = new SqlDataAdapter(command))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        if (dt.Rows.Count > 0)
                        {
                            return InitializeObject<UserTask>(dt);
                        }
                    }
                }
            }
            return null;
        }

        private T InitializeObject<T>(DataTable dt) where T : new()
        {
            T obj = new T();
            var properties = typeof(T).GetProperties();
            foreach (var property in properties)
            {
                if (dt.Columns.Contains(property.Name) && dt.Rows[0][property.Name] != DBNull.Value)
                {
                    property.SetValue(obj, Convert.ChangeType(dt.Rows[0][property.Name], property.PropertyType));
                }
            }
            return obj;
        }

        public bool InsertTask(UserTask task)
        {
            using (var transaction = new TransactionScope())
            {
                try
                {
                    using (var connection = new SqlConnection(_connectionString))
                    {
                        connection.Open();
                        var query = "INSERT INTO Tasks (Name, Description, StatusId, AssignedBy, AssignedOn, DueDate, StartDate, EndDate, CreatedBy, CreatedOn, UpdatedBy, UpdatedOn, PriorityId, CategoryId, ProjectId, UserId, TotalTimeSpent, UDF1, UDF2, UDF3, UDF4, UDF5) VALUES (@Name, @Description, @StatusId, @AssignedBy, @AssignedOn, @DueDate, @StartDate, @EndDate, @CreatedBy, @CreatedOn, @UpdatedBy, @UpdatedOn, @PriorityId, @CategoryId, @ProjectId, @UserId, @TotalTimeSpent, @UDF1, @UDF2, @UDF3, @UDF4, @UDF5)";
                        using (var command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@Name", task.Name);
                            command.Parameters.AddWithValue("@Description", task.Description);
                            command.Parameters.AddWithValue("@StatusId", task.StatusId ?? (object)DBNull.Value);
                            command.Parameters.AddWithValue("@AssignedBy", task.AssignedBy ?? (object)DBNull.Value);
                            command.Parameters.AddWithValue("@AssignedOn", task.AssignedOn ?? (object)DBNull.Value);
                            command.Parameters.AddWithValue("@DueDate", task.DueDate ?? (object)DBNull.Value);
                            command.Parameters.AddWithValue("@StartDate", task.StartDate);
                            command.Parameters.AddWithValue("@EndDate", task.EndDate);
                            command.Parameters.AddWithValue("@CreatedBy", task.CreatedBy ?? (object)DBNull.Value);
                            command.Parameters.AddWithValue("@CreatedOn", task.CreatedOn);
                            command.Parameters.AddWithValue("@UpdatedBy", task.UpdatedBy ?? (object)DBNull.Value);
                            command.Parameters.AddWithValue("@UpdatedOn", task.UpdatedOn ?? (object)DBNull.Value);
                            command.Parameters.AddWithValue("@PriorityId", task.PriorityId ?? (object)DBNull.Value);
                            command.Parameters.AddWithValue("@CategoryId", task.CategoryId ?? (object)DBNull.Value);
                            command.Parameters.AddWithValue("@ProjectId", task.ProjectId ?? (object)DBNull.Value);
                            command.Parameters.AddWithValue("@UserId", task.UserId ?? (object)DBNull.Value);
                            command.Parameters.AddWithValue("@TotalTimeSpent", task.TotalTimeSpent ?? (object)DBNull.Value);
                            command.Parameters.AddWithValue("@UDF1", task.UDF1 ?? (object)DBNull.Value);
                            command.Parameters.AddWithValue("@UDF2", task.UDF2 ?? (object)DBNull.Value);
                            command.Parameters.AddWithValue("@UDF3", task.UDF3 ?? (object)DBNull.Value);
                            command.Parameters.AddWithValue("@UDF4", task.UDF4 ?? (object)DBNull.Value);
                            command.Parameters.AddWithValue("@UDF5", task.UDF5 ?? (object)DBNull.Value);
                            command.ExecuteNonQuery();
                        }
                    }
                    transaction.Complete();
                    return true;
                }
                catch (Exception ex)
                {
                    return false;
                }
            }
        }
    }
}
