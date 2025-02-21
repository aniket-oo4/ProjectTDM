using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDM.Service.DTOs
{
    public class UserDto
    {
        public int UserID { get; set; }
        public string WebUserName { get; set; }
        public string PersonalEmail { get; set; }
        public string MobileNo { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public int SecurityQuestionId { get; set; }
        public string SecurityAnswer { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public DateTime? LastLoggedOn { get; set; }
        public string LastSessionId { get; set; }
        public int OrganisationId { get; set; }
        public int RoleId { get; set; }
    }
}
