using System;
using Microsoft.Data.SqlClient;
using System.Transactions;
using TDM.Data.Entities;
namespace YourNamespace
{
    public class UserDataManager
    {
        private readonly string _connectionString = "YourConnectionStringHere";

        public bool InsertUser(User user)
        {
            using (var transaction = new TransactionScope())
            {
                try
                {
                    
                    using (var connection = new SqlConnection(_connectionString))
                    {
                        connection.Open();
                        var query = "INSERT INTO Users (WebUserName, WebUserPassword, PersonalEmail, MobileNo, FirstName, MiddleName, LastName, BirthDate, SecurityQuestionId, SecurityAnswer, CreatedAt, UpdatedAt, LastLoggedOn, LastSessionId, OrganisationId, RoleId) VALUES (@WebUserName, @WebUserPassword, @PersonalEmail, @MobileNo, @FirstName, @MiddleName, @LastName, @BirthDate, @SecurityQuestionId, @SecurityAnswer, @CreatedAt, @UpdatedAt, @LastLoggedOn, @LastSessionId, @OrganisationId, @RoleId)";
                        using (var command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@WebUserName", user.WebUserName);
                            command.Parameters.AddWithValue("@WebUserPassword", user.WebUserPassword);
                            command.Parameters.AddWithValue("@PersonalEmail", user.PersonalEmail);
                            command.Parameters.AddWithValue("@MobileNo", user.MobileNo);
                            command.Parameters.AddWithValue("@FirstName", user.FirstName);
                            command.Parameters.AddWithValue("@MiddleName", user.MiddleName ?? (object)DBNull.Value);
                            command.Parameters.AddWithValue("@LastName", user.LastName);
                            command.Parameters.AddWithValue("@BirthDate", user.BirthDate);
                            command.Parameters.AddWithValue("@SecurityQuestionId", user.SecurityQuestionId ==0? (object)DBNull.Value : user.SecurityQuestionId) ;
                            command.Parameters.AddWithValue("@SecurityAnswer", user.SecurityAnswer ?? (object)DBNull.Value);
                            command.Parameters.AddWithValue("@CreatedAt", user.CreatedAt);
                            command.Parameters.AddWithValue("@UpdatedAt", user.UpdatedAt);
                            command.Parameters.AddWithValue("@LastLoggedOn", user.LastLoggedOn ?? (object)DBNull.Value);
                            command.Parameters.AddWithValue("@LastSessionId", user.LastSessionId ?? (object)DBNull.Value);
                            command.Parameters.AddWithValue("@OrganisationId", user.OrganisationId== 0 ? (object)DBNull.Value :user.OrganisationId );
                            command.Parameters.AddWithValue("@RoleId", user.RoleId);
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

        public bool UpdateUser(User user)
        {
            using (var transaction = new TransactionScope())
            {
                try
                {
                    using (var connection = new SqlConnection(_connectionString))
                    {
                        connection.Open();
                        var query = "UPDATE Users SET WebUserName = @WebUserName, WebUserPassword = @WebUserPassword, PersonalEmail = @PersonalEmail, MobileNo = @MobileNo, FirstName = @FirstName, MiddleName = @MiddleName, LastName = @LastName, BirthDate = @BirthDate, SecurityQuestionId = @SecurityQuestionId, SecurityAnswer = @SecurityAnswer, UpdatedAt = @UpdatedAt, LastLoggedOn = @LastLoggedOn, LastSessionId = @LastSessionId, OrganisationId = @OrganisationId, RoleId = @RoleId WHERE UserID = @UserID";
                        using (var command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@UserID", user.UserID);
                            command.Parameters.AddWithValue("@WebUserName", user.WebUserName);
                            command.Parameters.AddWithValue("@WebUserPassword", user.WebUserPassword);
                            command.Parameters.AddWithValue("@PersonalEmail", user.PersonalEmail);
                            command.Parameters.AddWithValue("@MobileNo", user.MobileNo);
                            command.Parameters.AddWithValue("@FirstName", user.FirstName);
                            command.Parameters.AddWithValue("@MiddleName", user.MiddleName ?? (object)DBNull.Value);
                            command.Parameters.AddWithValue("@LastName", user.LastName);
                            command.Parameters.AddWithValue("@BirthDate", user.BirthDate);
                            command.Parameters.AddWithValue("@SecurityQuestionId", user.SecurityQuestionId == 0 ? (object)DBNull.Value : user.SecurityQuestionId);
                            command.Parameters.AddWithValue("@SecurityAnswer", user.SecurityAnswer ?? (object)DBNull.Value);
                            command.Parameters.AddWithValue("@UpdatedAt", user.UpdatedAt);
                            command.Parameters.AddWithValue("@LastLoggedOn", user.LastLoggedOn ?? (object)DBNull.Value);
                            command.Parameters.AddWithValue("@LastSessionId", user.LastSessionId ?? (object)DBNull.Value);
                            command.Parameters.AddWithValue("@OrganisationId", user.OrganisationId == 0 ? (object)DBNull.Value : user.OrganisationId);
                            command.Parameters.AddWithValue("@RoleId", user.RoleId);
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

        public bool DeleteUser(int userId)
        {
            using (var transaction = new TransactionScope())
            {
                try
                {
                    using (var connection = new SqlConnection(_connectionString))
                    {
                        connection.Open();
                        var query = "DELETE FROM Users WHERE UserID = @UserID";
                        using (var command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@UserID", userId);
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
