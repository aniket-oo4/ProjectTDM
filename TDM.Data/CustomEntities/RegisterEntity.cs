using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDM.Data.CustomEntities
{
    public class RegisterEntity
    {
        // Mandatory fields
        public int UserID { get; set; }
        public string WebUserName { get; set; }
        public byte[] WebUserPassword { get; set; }
        public string PersonalEmail { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        // Optional fields
        public string? MobileNo { get; set; }
        public string? MiddleName { get; set; }
        public int? RoleId { get; set; }
    }
}
