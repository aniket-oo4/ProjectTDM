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
    internal class RoleDataManager
    {
        private string _connectionString;

        public bool InsertRole(Role role)
        {
            using (var transaction = new TransactionScope())
            {
                try
                {
                    using (var connection = new SqlConnection(_connectionString))
                    {
                        connection.Open();
                        var query = "INSERT INTO Roles (RoleName, RoleDescription, CreatedAt, CreatedBy, UpdatedAt, UpdatedBy) VALUES (@RoleName, @RoleDescription, @CreatedAt, @CreatedBy, @UpdatedAt, @UpdatedBy)";
                        using (var command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@RoleName", role.RoleName);
                            command.Parameters.AddWithValue("@RoleDescription", role.RoleDescription);
                            command.Parameters.AddWithValue("@CreatedAt", role.CreatedAt);
                            command.Parameters.AddWithValue("@CreatedBy", role.CreatedBy);
                            command.Parameters.AddWithValue("@UpdatedAt", role.UpdateAt);
                            command.Parameters.AddWithValue("@UpdatedBy", role.UpdatedBy);
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

        public bool UpdateRole(Role role)
        {
            using (var transaction = new TransactionScope())
            {
                try
                {
                    using (var connection = new SqlConnection(_connectionString))
                    {
                        connection.Open();
                        var query = "UPDATE Roles SET RoleName = @RoleName, RoleDescription = @RoleDescription, UpdatedAt = @UpdatedAt, UpdatedBy = @UpdatedBy WHERE RoleId = @RoleId";
                        using (var command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@RoleId", role.RoleId);
                            command.Parameters.AddWithValue("@RoleName", role.RoleName);
                            command.Parameters.AddWithValue("@RoleDescription", role.RoleDescription);
                            command.Parameters.AddWithValue("@UpdatedAt", role.UpdateAt);
                            command.Parameters.AddWithValue("@UpdatedBy", role.UpdatedBy);
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

        public bool DeleteRole(int roleId)
        {
            using (var transaction = new TransactionScope())
            {
                try
                {
                    using (var connection = new SqlConnection(_connectionString))
                    {
                        connection.Open();
                        var query = "DELETE FROM Roles WHERE RoleId = @RoleId";
                        using (var command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@RoleId", roleId);
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
