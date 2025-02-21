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
    internal class OrganisationDataManager
    {
        private string _connectionString;

        public bool InsertOrganisation(Organisation organisation)
        {
            using (var transaction = new TransactionScope())
            {
                try
                {
                    using (var connection = new SqlConnection(_connectionString))
                    {
                        connection.Open();
                        var query = "INSERT INTO Organisations (Name, Description, CreatedBy, CreatedAt, UpdatedAt, UpdatedBy) VALUES (@Name, @Description, @CreatedBy, @CreatedAt, @UpdatedAt, @UpdatedBy)";
                        using (var command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@Name", organisation.Name);
                            command.Parameters.AddWithValue("@Description", organisation.Description);
                            command.Parameters.AddWithValue("@CreatedBy", organisation.CreatedBy);
                            command.Parameters.AddWithValue("@CreatedAt", organisation.CreatedAt);
                            command.Parameters.AddWithValue("@UpdatedAt", organisation.UpdatedAt);
                            command.Parameters.AddWithValue("@UpdatedBy", organisation.UpdatedBy);
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

        public bool UpdateOrganisation(Organisation organisation)
        {
            using (var transaction = new TransactionScope())
            {
                try
                {
                    using (var connection = new SqlConnection(_connectionString))
                    {
                        connection.Open();
                        var query = "UPDATE Organisations SET Name = @Name, Description = @Description, UpdatedAt = @UpdatedAt, UpdatedBy = @UpdatedBy WHERE OrganisationId = @OrganisationId";
                        using (var command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@OrganisationId", organisation.OrganisationId);
                            command.Parameters.AddWithValue("@Name", organisation.Name);
                            command.Parameters.AddWithValue("@Description", organisation.Description);
                            command.Parameters.AddWithValue("@UpdatedAt", organisation.UpdatedAt);
                            command.Parameters.AddWithValue("@UpdatedBy", organisation.UpdatedBy);
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

        public bool DeleteOrganisation(int organisationId)
        {
            using (var transaction = new TransactionScope())
            {
                try
                {
                    using (var connection = new SqlConnection(_connectionString))
                    {
                        connection.Open();
                        var query = "DELETE FROM Organisations WHERE OrganisationId = @OrganisationId";
                        using (var command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@OrganisationId", organisationId);
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
