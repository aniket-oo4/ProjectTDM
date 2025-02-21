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

    public class TaskHistoryDataManager
    {
        private string _connectionString;

        public bool InsertTaskHistory(TaskHistory taskHistory)
        {
            using (var transaction = new TransactionScope())
            {
                try
                {
                    using (var connection = new SqlConnection(_connectionString))
                    {
                        connection.Open();
                        var query = "INSERT INTO TaskHistory (TaskId, ChangedBy, ChangeDescription, ChangedAt) VALUES (@TaskId, @ChangedBy, @ChangeDescription, @ChangedAt)";
                        using (var command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@TaskId", taskHistory.TaskId);
                            command.Parameters.AddWithValue("@ChangedBy", taskHistory.ChangedBy);
                            command.Parameters.AddWithValue("@ChangeDescription", taskHistory.ChangeDescription);
                            command.Parameters.AddWithValue("@ChangedAt", taskHistory.ChangedAt);
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

        public bool UpdateTaskHistory(TaskHistory taskHistory)
        {
            using (var transaction = new TransactionScope())
            {
                try
                {
                    using (var connection = new SqlConnection(_connectionString))
                    {
                        connection.Open();
                        var query = "UPDATE TaskHistory SET TaskId = @TaskId, ChangedBy = @ChangedBy, ChangeDescription = @ChangeDescription, ChangedAt = @ChangedAt WHERE HistoryId = @HistoryId";
                        using (var command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@HistoryId", taskHistory.HistoryId);
                            command.Parameters.AddWithValue("@TaskId", taskHistory.TaskId);
                            command.Parameters.AddWithValue("@ChangedBy", taskHistory.ChangedBy);
                            command.Parameters.AddWithValue("@ChangeDescription", taskHistory.ChangeDescription);
                            command.Parameters.AddWithValue("@ChangedAt", taskHistory.ChangedAt);
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

        public bool DeleteTaskHistory(int historyId)
        {
            using (var transaction = new TransactionScope())
            {
                try
                {
                    using (var connection = new SqlConnection(_connectionString))
                    {
                        connection.Open();
                        var query = "DELETE FROM TaskHistory WHERE HistoryId = @HistoryId";
                        using (var command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@HistoryId", historyId);
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
