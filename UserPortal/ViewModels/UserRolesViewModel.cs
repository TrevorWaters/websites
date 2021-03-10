using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace UserPortal.ViewModels
{
    public partial class UserRolesViewModel
    {
                
        [Key]
        public int UserRoleId { get; set; }
        public int UserId { get; set; }
        public int RoleId { get; set; }
        public bool IsCW { get; set; }
        public bool IsAIMS { get; set; }

        public virtual RolesViewModel Role { get; set; }
    }
}
