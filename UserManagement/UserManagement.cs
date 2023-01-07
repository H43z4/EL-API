using Microsoft.AspNetCore.Identity;
using Microsoft.Data.SqlClient;
using Models.DatabaseModels.Authentication;
using Models.ViewModels.Common;
using Models.ViewModels.Identity;
using RepositoryLayer;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace UserManagement
{
    public interface IUserManagement
    {
        Task<DataSet> GetUser(string username);
        Task<DataSet> GetUserInfo(string username);
        GeneralType<User> SaveUser(User user);
        GeneralType<Role> SaveRole(Role role);
        GeneralType<Resource> SaveResource(Resource resource);
        GeneralType<UserRole> SaveUserRole(UserRole userRole);
        List<Role> GetUserRoles(long userId);
    }

    public class UserManagement : IUserManagement
    {
        private readonly AppDbContext context;
        readonly IAdoNet adoNet;

        public UserManagement(AppDbContext context, IAdoNet adoNet)
        {
            this.context = context;
            this.adoNet = adoNet;
        }

        //public User GetUser(string username)
        //{
        //    return this.context.User.Join(this.context.per).SingleOrDefault(x => x.Person.PersonName == username);
        //}

        public async Task<DataSet> GetUser(string username)
        {
            SqlParameter[] sql = new SqlParameter[1];
            sql[0] = new SqlParameter("@UserName", username);

            var ds = await this.adoNet.ExecuteUsingDataAdapter("[Auth].[GetUser]", sql);

            return ds;
        }

        public async Task<DataSet> GetUserInfo(string username)
        {
            SqlParameter[] sql = new SqlParameter[1];
            sql[0] = new SqlParameter("@UserName", username);

            var ds = await this.adoNet.ExecuteUsingDataAdapter("[Auth].[GetUserInfo]", sql);

            return ds;
        }

        //public VwUser GetUserInfo(string username)
        //{
        //    var user = this.context.User.SingleOrDefault(x => x.Person.PersonName == username);

        //    var userRoles = this.context.UserRole.Where(x => x.UserId == user.UserId)
        //        .Join(this.context.Role, a => a.RoleId, b => b.RoleId, (a, b) => new { role = b })
        //        .Select(x => new Role 
        //        {
        //            RoleNameAbbr = x.role.RoleNameAbbr,
        //            RoleId = x.role.RoleId,
        //            RoleDescription = x.role.RoleDescription,
        //            RoleName = x.role.RoleName
        //        })
        //        .ToList();

        //    return new VwUser()
        //    {
        //        FullName = user.FullName,
        //        UserId = user.UserId,
        //        UserName = user.UserName,
        //        UserRoles = userRoles
        //    };
        //}

        public List<Role> GetUserRoles(long userId)
        {
            var userRoles = this.context.UserRole.Where(x => x.UserId == userId)
                .Join(this.context.Role, a => a.RoleId, b => b.RoleId, (a, b) => new { role = b })
                .Select(x => new Role
                {
                    RoleNameAbbr = x.role.RoleNameAbbr,
                    RoleId = x.role.RoleId,
                    RoleDescription = x.role.RoleDescription,
                    RoleName = x.role.RoleName
                })
                .ToList();

            return userRoles;
        }

        public GeneralType<User> SaveUser(User user)
        {
            if (user.UserId == 0)
            {
                var passwordHasher = new PasswordHasher<User>();
                //user.Password = passwordHasher.HashPassword(user, user.Password);
                //user.UserStatusId = 1;
                //user.FullName = user.FullName;
                this.context.User.Add(user);
            }
            else
            {
                this.context.Entry<User>(user).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            }

            int result = this.context.SaveChanges();

            return new GeneralType<User>() { Type = user, Status = result > 0 };
        }

        public GeneralType<Role> SaveRole(Role role)
        {
            if (role.RoleId == 0)
            {
                this.context.Role.Add(role);
            }
            else
            {
                this.context.Entry<Role>(role).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            }

            int result = this.context.SaveChanges();

            return new GeneralType<Role>() { Type = role, Status = result > 0 };
        }

        public GeneralType<Resource> SaveResource(Resource resource)
        {
            if (resource.ResourceId == 0)
            {
                this.context.Resource.Add(resource);
            }
            else
            {
                this.context.Entry<Resource>(resource).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            }

            int result = this.context.SaveChanges();

            return new GeneralType<Resource>() { Type = resource, Status = result > 0 };
        }

        public GeneralType<UserRole> SaveUserRole(UserRole userRole)
        {
            throw new System.NotImplementedException();
        }
    }
}
