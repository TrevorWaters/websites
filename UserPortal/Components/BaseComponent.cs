using Microsoft.AspNetCore.Components;
using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using AutoMapper;
using System.Threading.Tasks;
using UserPortal.Data;
using UserPortal;
using UserPortal.ViewModels;

public abstract class BaseComponent: ComponentBase, IDisposable
{
    // ... ... ...

    [Inject]
    protected IDbContextFactory<UserPortalContext> DbContextFactory { get; set; }

    protected UserPortalContext DbContext { get; set; }

    [Inject]
    protected IMapper Mapper { get; set; }

    // ... ... ...

    protected void InitDependencies()
    {
        DbContext = DbContextFactory.CreateDbContext();

        // setup logger, other things

        
    }

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
    #endregion Public methods

    public void Dispose()
    {
        DbContext?.Dispose(); // DbContext will be disposed automatically
    }
}