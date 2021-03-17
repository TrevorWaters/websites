using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace UserPortal.ViewModels
{
    public partial class UserViewModel
    {
        public UserViewModel()
        {
            Roles = new HashSet<RolesViewModel>();
        }
        
        public IEnumerable<RolesViewModel> Roles { get; set; }
        public long UserId { get; set; }
        public string FirstName { get; set; }
        public string MiddleInitial { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public string WorkPhone { get; set; }
        public string JobTitle { get; set; }
        public string AgencyName { get; set; }
        public string AgencyAddress { get; set; }
        public string AgencyCity { get; set; }
        public long AgencyZipCode { get; set; }
        public byte[] IsApproved { get; set; }
        public long? Comments { get; set; }
    }
}
