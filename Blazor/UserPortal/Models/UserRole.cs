using System;
using System.Collections.Generic;

#nullable disable

namespace UserPortal.Models
{
    public partial class UserRole
    {
        public long UserRoleId { get; set; }
        public long UserId { get; set; }
        public long RoleId { get; set; }
        public long IsCw { get; set; }
        public long IsAims { get; set; }
        public long IsApproved { get; set; }
    }
}
