using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TDM.Data.Common.CommonUtilities;
using TDM.Data.Entities;

namespace TDM.Data.DataManagers.CustomDataManagers
{
    public class AuthDataManager
    {
        public FunctionResponseEntity<User>  RegisterUser()
        {
            FunctionResponseEntity < User > response = new FunctionResponseEntity<User>();
            try
            {
                response.Data = new User();
                response.Data.UserID = 1;
                response.Data.FirstName = "admin";
                response.Data.LastName = "admin";
                response.Data.BirthDate = DateTime.Today;
                response.Data.CreatedAt = DateTime.Now;
                response.Data.UpdatedAt = DateTime.Now;
                response.Data.WebUserName = "admin";
                response.Data.WebUserPassword = Encoding.ASCII.GetBytes("admin");
                response.Data.PersonalEmail = "demo@gmaill";
                response.Data.MobileNo = "1234567890";
                response.Data.MiddleName = "admin";
                response.Data.RoleId = 1;

                response.Message = "User registered successfully";
                response.Success = true;



            }
            catch (Exception ex)
            {
                response.ErrorList.Add( ex.Message);
                response.Success=false;
                return response;
                throw;
            }
            // Register user logic
            return response;
        }
        public void LoginUser()
        {
            // Login user logic
        }
        public void LogoutUser()
        {
            // Logout user logic
        }
        public void UpdateUser()
        {
            // Update user logic
        }
        public void DeleteUser()
        {
            // Delete user logic
        }
    }
}
