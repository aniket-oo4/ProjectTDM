using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using TDM.Data.Entities;

namespace TDM.Data.DataManagers
{
    internal class TaskPriorityDataManager
    {
        private string _connectionString;

        public bool InsertTaskPriority(TaskPriority taskPriority)
        {
            using (var transaction = new TransactionScope())
            {
                try
                {
                    using (var connection = new SqlConnection(_connectionString))
                    {
                        connection.Open();
                        var query = "INSERT INTO TaskPriorities (Name, Description, CreatedAt, CreatedBy, UpdatedAt, UpdatedBy) VALUES (@Name, @Description, @CreatedAt, @CreatedBy, @UpdatedAt, @UpdatedBy)";
                        using (var command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@Name", taskPriority.Name);
                            command.Parameters.AddWithValue("@Description", taskPriority.Description ?? (object)DBNull.Value);
                            command.Parameters.AddWithValue("@CreatedAt", taskPriority.CreatedAt);
                            command.Parameters.AddWithValue("@CreatedBy", taskPriority.CreatedBy);
                            command.Parameters.AddWithValue("@UpdatedAt", taskPriority.UpdateAt);
                            command.Parameters.AddWithValue("@UpdatedBy", taskPriority.UpdatedBy);
                            command.ExecuteNonQuery();
                        }
                    }
                    transaction.Complete();
                    return true;
                }
                catch (Exception ex)
                {
                    // Log exception
                    return false;
                }
            }
        }

        public bool UpdateTaskPriority(TaskPriority taskPriority)
        {
            using (var transaction = new TransactionScope())
            {
                try
                {
                    using (var connection = new SqlConnection(_connectionString))
                    {
                        connection.Open();
                        var query = "UPDATE TaskPriorities SET Name = @Name, Description = @Description, UpdatedAt = @UpdatedAt, UpdatedBy = @UpdatedBy WHERE TaskPriorityId = @TaskPriorityId";
                        using (var command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@TaskPriorityId", taskPriority.TaskPriorityId);
                            command.Parameters.AddWithValue("@Name", taskPriority.Name);
                            command.Parameters.AddWithValue("@Description", taskPriority.Description ?? (object)DBNull.Value);
                            command.Parameters.AddWithValue("@UpdatedAt", taskPriority.UpdateAt);
                            command.Parameters.AddWithValue("@UpdatedBy", taskPriority.UpdatedBy);
                            command.ExecuteNonQuery();
                        }
                    }
                    transaction.Complete();
                    return true;
                }
                catch (Exception ex)
                {
                    // Log exception
                    return false;
                }
            }
        }

        public bool DeleteTaskPriority(int taskPriorityId)
        {
            using (var transaction = new TransactionScope())
            {
                try
                {
                    using (var connection = new SqlConnection(_connectionString))
                    {
                        connection.Open();
                        var query = "DELETE FROM TaskPriorities WHERE TaskPriorityId = @TaskPriorityId";
                        using (var command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@TaskPriorityId", taskPriorityId);
                            command.ExecuteNonQuery();
                        }
                    }
                    transaction.Complete();
                    return true;
                }
                catch (Exception ex)
                {
                    // Log exception
                    return false;
                }
            }
        }
    }
}
