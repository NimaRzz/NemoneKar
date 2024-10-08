using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MainProject.Domain.Model.Users;
using MainProject.Domain.Model.Customers;

namespace MainProject.Application.Interfaces.Contexts
{
    public interface IDataBaseContext
    {
        
        DbSet<Customer> Customers { get; set; }
        DbSet<Province> Provinces { get; set; }
        DbSet<City> Cities { get; set; }
       
        DbSet<User> Users { get; set; }
       
        DbSet<Role> Roles { get; set; }
        
        DbSet<UserInRole> UserInRoles { get; set; }
        
        int SaveChanges(bool AcceptAllSaveChangesOnSuccess);
        int SaveChanges();
        Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess, CancellationToken cancellationToken = new CancellationToken());
        Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken());
    }
}
