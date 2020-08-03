using AddmonApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AddmonApp.Services.Security
{
    public interface ICommon
    {
        Task CreateDefaultSuperAdmin();

        List<String> GetAllRoles();

        List<ApplicationUser> GetAllMembers();

        ApplicationUser GetMemberByApplicationId(string applicationId);

        Task<ApplicationUser> CreateApplicationUser(ApplicationUser applicationUser, string password);

    }
}
