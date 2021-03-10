using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace UserPortal.ViewModels
{
    public partial class UserViewModel
    {
        public UserViewModel()
        {
            UserRoles = new HashSet<UserRolesViewModel>();
        }
        
        [Key]
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string MiddleInitial { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public string WorkPhone { get; set; }
        public string JobTitle { get; set; }
        public string AgencyName { get; set; }
        public string AgencyAddress { get; set; }
        public string AgencyCity { get; set; }
        public string AgencyZipCode { get; set; }
        public bool IsApproved { get; set; }
        public string Comments { get; set; }

        public virtual ICollection<UserRolesViewModel> UserRoles { get; set; }
    }
}
