using System;
using System.Collections.Generic;

#nullable disable

namespace UserPortal.Models
{
    public partial class User
    {
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
        public string AgencyZipCode { get; set; }
        public string Comments { get; set; }
        public long? IsActive { get; set; }
    }
}
