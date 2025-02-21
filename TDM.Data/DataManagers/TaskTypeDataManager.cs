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
    internal class TaskTypeDataManager
    {
        private readonly string _connectionString;

        public bool InsertTaskType(TaskType taskType)
        {
            using (var transaction = new TransactionScope())
            {
                try
                {
                    using (var connection = new SqlConnection(_connectionString))
                    {
                        connection.Open();
                        var query = "INSERT INTO TaskTypes (TypeName, TypeDescription, CreatedAt, CreatedBy, UpdatedAt, UpdatedBy) VALUES (@TypeName, @TypeDescription, @CreatedAt, @CreatedBy, @UpdatedAt, @UpdatedBy)";
                        using (var command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@TypeName", taskType.TypeName);
                            command.Parameters.AddWithValue("@TypeDescription", taskType.TypeDescription ?? (object)DBNull.Value);
                            command.Parameters.AddWithValue("@CreatedAt", taskType.CreatedAt);
                            command.Parameters.AddWithValue("@CreatedBy", taskType.CreatedBy);
                            command.Parameters.AddWithValue("@UpdatedAt", taskType.UpdateAt);
                            command.Parameters.AddWithValue("@UpdatedBy", taskType.UpdatedBy);
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

        public bool UpdateTaskType(TaskType taskType)
        {
            using (var transaction = new TransactionScope())
            {
                try
                {
                    using (var connection = new SqlConnection(_connectionString))
                    {
                        connection.Open();
                        var query = "UPDATE TaskTypes SET TypeName = @TypeName, TypeDescription = @TypeDescription, UpdatedAt = @UpdatedAt, UpdatedBy = @UpdatedBy WHERE TypeId = @TypeId";
                        using (var command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@TypeId", taskType.TypeId);
                            command.Parameters.AddWithValue("@TypeName", taskType.TypeName);
                            command.Parameters.AddWithValue("@TypeDescription", taskType.TypeDescription ?? (object)DBNull.Value);
                            command.Parameters.AddWithValue("@UpdatedAt", taskType.UpdateAt);
                            command.Parameters.AddWithValue("@UpdatedBy", taskType.UpdatedBy);
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

        public bool DeleteTaskType(int typeId)
        {
            using (var transaction = new TransactionScope())
            {
                try
                {
                    using (var connection = new SqlConnection(_connectionString))
                    {
                        connection.Open();
                        var query = "DELETE FROM TaskTypes WHERE TypeId = @TypeId";
                        using (var command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@TypeId", typeId);
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
