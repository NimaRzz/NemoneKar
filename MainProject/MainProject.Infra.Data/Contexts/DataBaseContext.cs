﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MainProject.Application.Interfaces.Contexts;
using MainProject.Common.Roles;
using MainProject.Domain.Model.Customers;
using Microsoft.EntityFrameworkCore;
using MainProject.Domain.Model.Users;

namespace MainProject.Infra.Data.Contexts
{
    public class DataBaseContext:DbContext, IDataBaseContext
    {
        public DataBaseContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<User> Users { get; set; }
        
        public DbSet<Role> Roles { get; set; }
       
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Province> Provinces { get; set; }
        public DbSet<City> Cities { get; set; }
        
        public DbSet<UserInRole> UserInRoles { get; set; }
        


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<User>()
                .HasOne(c => c.Customer)
                .WithOne(u => u.User)
                .HasForeignKey<Customer>(u => u.UserId);


			modelBuilder.Entity<Province>()
				.HasMany(p => p.Cities)
				.WithOne(c => c.Province)
				.HasForeignKey(c => c.ProvinceId)
				.OnDelete(DeleteBehavior.NoAction);

			modelBuilder.Entity<Customer>()
				.HasOne(u => u.Province)
				.WithMany()
				.HasForeignKey(u => u.ProvinceId)
				.OnDelete(DeleteBehavior.NoAction);

			modelBuilder.Entity<Customer>()
				.HasOne(u => u.City)
				.WithMany()
				.HasForeignKey(u => u.CityId)
				.OnDelete(DeleteBehavior.NoAction);






			modelBuilder.Entity<User>().HasIndex(p => p.Email).IsUnique();

            // Seed Data

            SeedData(modelBuilder);

            //--برایه عدم نمایش اطلاعات حذف شده
            ApplyQueryFilter(modelBuilder);

        }

        private void ApplyQueryFilter(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasQueryFilter(p => !p.IsRemoved);
            modelBuilder.Entity<Customer>().HasQueryFilter(p => !p.IsRemoved);
        }
        
        private void SeedData(ModelBuilder modelBuilder)
        {
            //Roles
            modelBuilder.Entity<Role>().HasData(new Role{Id = 1, Name = nameof(UserRoles.Customer)});
            modelBuilder.Entity<Role>().HasData(new Role{Id = 2, Name = nameof(UserRoles.Admin)});
            modelBuilder.Entity<Role>().HasData(new Role{Id = 3, Name = nameof(UserRoles.Operator)});

            //Provinces
            modelBuilder.Entity<Province>().HasData(new Province { Id = 1, Name = nameof(Application.Common.Province.Province.Tehran) });
            modelBuilder.Entity<Province>().HasData(new Province { Id = 2, Name = nameof(Application.Common.Province.Province.Yazd) });
            modelBuilder.Entity<Province>().HasData(new Province { Id = 3, Name = nameof(Application.Common.Province.Province.Fars) });

            //Cities
            modelBuilder.Entity<City>().HasData(new City { Id = 1, Name = nameof(Application.Common.City.City.Tehran), ProvinceId = 1});
            modelBuilder.Entity<City>().HasData(new City { Id = 2, Name = nameof(Application.Common.City.City.Rey), ProvinceId = 1});
            modelBuilder.Entity<City>().HasData(new City { Id = 3, Name = nameof(Application.Common.City.City.PakDasht), ProvinceId = 1});
            
            modelBuilder.Entity<City>().HasData(new City { Id = 4, Name = nameof(Application.Common.City.City.Yazd), ProvinceId = 2});
            modelBuilder.Entity<City>().HasData(new City { Id = 5, Name = nameof(Application.Common.City.City.Mehriz), ProvinceId = 2});
            modelBuilder.Entity<City>().HasData(new City { Id = 6, Name = nameof(Application.Common.City.City.AbarKoh), ProvinceId = 2});
           
            modelBuilder.Entity<City>().HasData(new City { Id = 7, Name = nameof(Application.Common.City.City.Shiraz), ProvinceId = 3});
            modelBuilder.Entity<City>().HasData(new City { Id = 8, Name = nameof(Application.Common.City.City.NeyRiz), ProvinceId = 3});
            modelBuilder.Entity<City>().HasData(new City { Id = 9, Name = nameof(Application.Common.City.City.Abade), ProvinceId = 3});
        }
    }
}
