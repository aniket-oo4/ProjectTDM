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
    internal class ProjectDataManager
    {
        private readonly string _connectionString = "your_connection_string";


        public bool InsertProject(Project project)
        {
            using (var transaction = new TransactionScope())
            {
                try
                {
                    using (var connection = new SqlConnection(_connectionString))
                    {
                        connection.Open();
                        var query = "INSERT INTO Projects (ProjectName, ProjectDescription, CreatedAt, CreatedBy, UpdatedAt, UpdatedBy, OrganisationId) VALUES (@ProjectName, @ProjectDescription, @CreatedAt, @CreatedBy, @UpdatedAt, @UpdatedBy, @OrganisationId)";
                        using (var command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@ProjectName", project.ProjectName);
                            command.Parameters.AddWithValue("@ProjectDescription", project.ProjectDescription);
                            command.Parameters.AddWithValue("@CreatedAt", project.CreatedAt);
                            command.Parameters.AddWithValue("@CreatedBy", project.CreatedBy);
                            command.Parameters.AddWithValue("@UpdatedAt", project.UpdatedAt);
                            command.Parameters.AddWithValue("@UpdatedBy", project.UpdatedBy);
                            command.Parameters.AddWithValue("@OrganisationId", project.OrganisationId);
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

        public bool UpdateProject(Project project)
        {
            using (var transaction = new TransactionScope())
            {
                try
                {
                    using (var connection = new SqlConnection(_connectionString))
                    {
                        connection.Open();
                        var query = "UPDATE Projects SET ProjectName = @ProjectName, ProjectDescription = @ProjectDescription, UpdatedAt = @UpdatedAt, UpdatedBy = @UpdatedBy WHERE ProjectId = @ProjectId";
                        using (var command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@ProjectId", project.ProjectId);
                            command.Parameters.AddWithValue("@ProjectName", project.ProjectName);
                            command.Parameters.AddWithValue("@ProjectDescription", project.ProjectDescription);
                            command.Parameters.AddWithValue("@UpdatedAt", project.UpdatedAt);
                            command.Parameters.AddWithValue("@UpdatedBy", project.UpdatedBy);
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

        public bool DeleteProject(int projectId)
        {
            using (var transaction = new TransactionScope())
            {
                try
                {
                    using (var connection = new SqlConnection(_connectionString))
                    {
                        connection.Open();
                        var query = "DELETE FROM Projects WHERE ProjectId = @ProjectId";
                        using (var command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@ProjectId", projectId);
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
