using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace UserPortal.ViewModels
{
    public partial class UserRolesViewModel
    {
                
        [Key]
        public long UserRoleId { get; set; }
        public long UserId { get; set; }
        public long RoleId { get; set; }
        public byte[] IsCw { get; set; }
        public byte[] IsAims { get; set; }
        public byte[] IsApproved { get; set; }

        public virtual RolesViewModel Role { get; set; }
    }
}
