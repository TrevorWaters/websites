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
        public byte[] IsCw { get; set; }
        public byte[] IsAims { get; set; }
        public byte[] IsApproved { get; set; }
    }
}
