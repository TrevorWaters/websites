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
        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        public string MiddleInitial { get; set; }
        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [Required]
        [Display(Name = "Email Address")]
        [EmailAddress(ErrorMessage = "Please enter a valid Email Address.")]
        public string EmailAddress { get; set; }
        [Required]
        [Display(Name = "Work Phone Number")]
        [Phone]
        public string WorkPhone { get; set; }
        [Required]
        [Display(Name = "Job Title")]
        public string JobTitle { get; set; }
        [Required]
        [Display(Name = "Agency Name")]
        public string AgencyName { get; set; }
        [Required]
        [Display(Name = "Agency Address")]
        public string AgencyAddress { get; set; }
        [Required]
        [Display(Name = "Agency City")]
        public string AgencyCity { get; set; }
        [Required]
        [Display(Name = "Agency ZIP Code")]
        [StringLength(5, ErrorMessage = "Please enter a valid ZIP Code.")]
        [MinLength(5, ErrorMessage = "Please enter 5 digits for the ZIP Code.")]
        
        public string AgencyZipCode { get; set; }
        public string Comments { get; set; }
    }
}
