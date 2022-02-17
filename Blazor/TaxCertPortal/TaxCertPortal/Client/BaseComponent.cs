
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

public abstract class BaseComponent : ComponentBase
{
    // ... ... ...

    //[Inject]
    //protected IDbContextFactory<TaxCertPortalContext> DbContextFactory { get; set; }

    //protected UsersContext DbContext { get; set; }

    //[Inject]
    //protected IMapper Mapper { get; set; }

    // ... ... ...

    //protected void InitDependencies()
    //{
    //    DbContext = DbContextFactory.CreateDbContext();

    //    // setup logger, other things


    //}

    //#region Public methods
    ///// <summary>
    ///// This method returns the list of users
    ///// </summary>
    ///// <returns></returns>
    //public async Task<List<UserViewModel>> GetUsersAsync()
    //{
    //    try
    //    {
    //        var users = await DbContext.Users.ToListAsync();
    //        var userList = Mapper.Map<List<User>, List<UserViewModel>>(users);
    //        return userList;
    //    }

    //    catch
    //    {
    //        throw;
    //    }
    //}

    ///// <summary>
    ///// This method returns a single user
    ///// </summary>
    ///// <returns></returns>
    //public async Task<UserViewModel> GetCertificateAsync(long userId)
    //{
    //    try
    //    {
    //        var user = await DbContext.Users.AsNoTracking().SingleOrDefaultAsync(x => x.UserId == userId);
    //        var userVM = Mapper.Map<User, UserViewModel>(user);
    //        return userVM;
    //    }

    //    catch
    //    {
    //        throw;
    //    }
    //}

    ///// <summary>
    ///// This method add a new user to the DbContext and saves it
    ///// </summary>
    ///// <param name="user"></param>
    ///// <returns></returns>
    //public async Task<UserViewModel> AddUserAsync(UserViewModel userVM)
    //{
    //    try
    //    {
    //        var user = Mapper.Map<UserViewModel, User>(userVM);
    //        DbContext.Users.Add(user);
    //        var userSaved = await DbContext.SaveChangesAsync();

    //        var userRole = new UserRole();
    //        userRole.IsApproved = 0;
    //        userRole.RoleId = 2;
    //        userRole.IsAims = 0;
    //        userRole.IsCw = 0;
    //        while (userSaved == 1)
    //        {
    //            userRole.UserId = user.UserId;
    //            DbContext.UserRoles.Add(userRole);
    //            await DbContext.SaveChangesAsync();
    //            return userVM;
    //        }
    //    }
    //    catch (Exception)
    //    {
    //        throw;
    //    }
    //    return userVM;
    //}
    ///// <summary>
    ///// This method update and existing user and saves the changes
    ///// </summary>
    ///// <param name="user"></param>
    ///// <returns></returns>
    //public async Task<UserViewModel> UpdateUserAsync(UserViewModel userVM)
    //{
    //    try
    //    {

    //        var user = Mapper.Map<UserViewModel, User>(userVM);
    //        DbContext.Update(user);
    //        await DbContext.SaveChangesAsync();
    //    }
    //    catch (Exception)
    //    {
    //        throw;
    //    }
    //    return userVM;
    //}

    ///// <summary>
    ///// This method removes and existing user from the DbContext and saves it
    ///// </summary>
    ///// <param name="user"></param>
    ///// <returns></returns>
    //public async Task DeleteUserAsync(long userId)
    //{
    //    try
    //    {

    //        var user = DbContext.Users.FirstOrDefault(p => p.UserId == userId);
    //        DbContext.Users.Remove(user);
    //        await DbContext.SaveChangesAsync();
    //    }
    //    catch (Exception)
    //    {
    //        throw;
    //    }
    //}

    ///// <summary>
    ///// This method removes and existing user from the DbContext and saves it
    ///// </summary>
    ///// <param name="user"></param>
    ///// <returns></returns>
    //public async Task<IEnumerable<RolesViewModel>> GetRolesAsync(IEnumerable<RolesViewModel> rolesVM)
    //{
    //    try
    //    {
    //        if (rolesVM == null)
    //        {
    //            var roles = await DbContext.Roles.ToListAsync();
    //            rolesVM = Mapper.Map<IEnumerable<Role>, IEnumerable<RolesViewModel>>(roles);
    //            return rolesVM;
    //        }

    //    }
    //    catch (Exception)
    //    {
    //        throw;
    //    }
    //    return rolesVM;
    //}

    //public async Task<string> ToggleUserApprovalAsync(long userId)
    //{
    //    try
    //    {
    //        var userRole = await DbContext.UserRoles.Where(x => x.UserId == userId).SingleOrDefaultAsync();

    //        if (userRole.IsApproved == 1)
    //        {
    //            userRole.IsApproved = 0;
    //            DbContext.Update(userRole);
    //            await DbContext.SaveChangesAsync();

    //        }
    //        else
    //        {
    //            userRole.IsApproved = 1;
    //            DbContext.Update(userRole);
    //            await DbContext.SaveChangesAsync();
    //        }

    //        return "Success!";

    //    }
    //    catch (Exception)
    //    {
    //        throw;
    //    }
    //}

    //public async Task<string> ToggleUserIsActiveAsync(long userId)
    //{
    //    try
    //    {
    //        var user = await DbContext.Users.Where(x => x.UserId == userId).SingleOrDefaultAsync();

    //        if (user.IsActive == 1)
    //        {
    //            user.IsActive = 0;
    //            DbContext.Update(user);
    //            await DbContext.SaveChangesAsync();

    //        }
    //        else
    //        {
    //            user.IsActive = 1;
    //            DbContext.Update(user);
    //            await DbContext.SaveChangesAsync();
    //        }

    //        return "Success!";

    //    }
    //    catch (Exception)
    //    {
    //        throw;
    //    }
    //}
    //#endregion Public methods

    //public void Dispose()
    //{
    //    DbContext?.Dispose(); // DbContext will be disposed automatically
    //}
}