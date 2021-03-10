  
using Microsoft.EntityFrameworkCore;
using System;
using System.Diagnostics;
using System.Threading.Tasks;
using UserPortal.ViewModels;
using UserPortal.Data;

namespace UserPortal.Data
{
    public class UserPortalContext : DbContext
{
    #region Contructor
    public UserPortalContext(DbContextOptions<UserPortalContext> options)
            : base(options)
    {
    }
    #endregion
    #region Public properties
    public DbSet<UserViewModel> Users { get; set; }
    #endregion
    #region Overidden methods
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
    }
    #endregion
}
}
