using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace UserPortal.ViewModels
{
    public partial class RolesViewModel
    {

        [Key]
        public int RoleId { get; set; }
        public string RoleName { get; set; }

        public virtual ICollection<UserRolesViewModel> Users { get; set; }
    }
}
