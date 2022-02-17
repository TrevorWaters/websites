/* using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using UserPortal.ViewModels;

namespace UserPortal.Data
{
    public class UserPortalServices : BaseComponent
{
    #region Private members
    private UserPortalContext dbContext;
    #endregion
    #region Constructor
    public UserPortalServices(UserPortalContext dbContext)
    {
        dbContext = DbContext;
    }
    #endregion
    #region Public methods
    /// <summary>
    /// This method returns the list of users
    /// </summary>
    /// <returns></returns>
    public async Task<List<UserViewModel>> GetUsersAsync()
    {
        return await DbContext.Users.ToListAsync();
    }
    /// <summary>
    /// This method add a new user to the DbContext and saves it
    /// </summary>
    /// <param name="user"></param>
    /// <returns></returns>
    public async Task<UserViewModel> AddUserAsync(UserViewModel user)
    {
        try
        {
            DbContext.Users.Add(user);
            await DbContext.SaveChangesAsync();
        }
        catch (Exception)
        {
            throw;
        }
        return user;
    }
    /// <summary>
    /// This method update and existing user and saves the changes
    /// </summary>
    /// <param name="user"></param>
    /// <returns></returns>
    public async Task<UserViewModel> UpdateUserAsync(UserViewModel user)
    {
        try
        {
            var productExist = DbContext.Users.FirstOrDefault(p => p.UserId == user.UserId);
            if (productExist != null)
            {
                DbContext.Update(user);
                await DbContext.SaveChangesAsync();
            }
        }
        catch (Exception)
        {
            throw;
        }
        return user;
    }
    /// <summary>
    /// This method removes and existing user from the DbContext and saves it
    /// </summary>
    /// <param name="user"></param>
    /// <returns></returns>
    public async Task DeleteUserAsync(UserViewModel user)
    {
        try
        {
            DbContext.Users.Remove(user);
            await DbContext.SaveChangesAsync();
        }
        catch (Exception)
        {
            throw;
        }
    }
    #endregion
}
}
 */