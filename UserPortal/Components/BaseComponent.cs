using Microsoft.AspNetCore.Components;
using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using AutoMapper;
using System.Threading.Tasks;
using UserPortal.Models;
using UserPortal.Extensions;
using UserPortal.ViewModels;

public abstract class BaseComponent: ComponentBase, IDisposable
{
    // ... ... ...

    [Inject]
    protected IDbContextFactory<UsersContext> DbContextFactory { get; set; }

    protected UsersContext DbContext { get; set; }

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
        var users = await DbContext.Users.ToListAsync();
        var userList = Mapper.Map<List<User>, List<UserViewModel>>(users);
        return userList;
    }
    /// <summary>
    /// This method add a new user to the DbContext and saves it
    /// </summary>
    /// <param name="user"></param>
    /// <returns></returns>
    public async Task<UserViewModel> AddUserAsync(UserViewModel userVM)
    {
        try
        {
            var user = Mapper.Map<UserViewModel, User>(userVM);
            DbContext.Users.Add(user);
            await DbContext.SaveChangesAsync();
        }
        catch (Exception)
        {
            throw;
        }
        return userVM;
    }
    /// <summary>
    /// This method update and existing user and saves the changes
    /// </summary>
    /// <param name="user"></param>
    /// <returns></returns>
    public async Task<UserViewModel> UpdateUserAsync(UserViewModel userVM)
    {
        try
        {

            var userExist = DbContext.Users.FirstOrDefault(p => p.UserId == userVM.UserId);
            if (userExist != null)
            {
                var user = Mapper.Map<UserViewModel, User>(userVM);
                DbContext.Update(user);
                await DbContext.SaveChangesAsync();
            }
        }
        catch (Exception)
        {
            throw;
        }
        return userVM;
    }
    /// <summary>
    /// This method removes and existing user from the DbContext and saves it
    /// </summary>
    /// <param name="user"></param>
    /// <returns></returns>
    public async Task DeleteUserAsync(UserViewModel userVM)
    {
        try
        {
            var user = Mapper.Map<UserViewModel, User>(userVM);
            DbContext.Users.Remove(user);
            await DbContext.SaveChangesAsync();
        }
        catch (Exception)
        {
            throw;
        }
    }

        /// <summary>
    /// This method removes and existing user from the DbContext and saves it
    /// </summary>
    /// <param name="user"></param>
    /// <returns></returns>
    public async Task<IEnumerable<RolesViewModel>> GetRolesAsync(IEnumerable<RolesViewModel> rolesVM)
    {
        try
        {
            if (rolesVM == null)
            {
                var roles = await DbContext.Roles.ToListAsync();
                rolesVM = Mapper.Map<IEnumerable<Role>, IEnumerable<RolesViewModel>>(roles);
                return rolesVM;
            }

        }
        catch (Exception)
        {
            throw;
        }
        return rolesVM;
    }
    #endregion Public methods

    public void Dispose()
    {
        DbContext?.Dispose(); // DbContext will be disposed automatically
    }
}