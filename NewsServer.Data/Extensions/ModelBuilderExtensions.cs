using Microsoft.EntityFrameworkCore;
using NewsServer.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsServer.Data.Extensions
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            var userId = new Guid("1b60fd43-a1b5-4214-9ccc-d239f0f4c97b");
            var roleId = new Guid("1b60fd43-a1b5-4214-9ccc-d239f0f4c97c");

            modelBuilder.Entity<AppRole>().HasData(
                new AppRole()
                {
                    Id = roleId,
                    Name = "ADMIN",
                    Description = "Administration role",
                    Created_by = roleId,
                    Created_at = DateTime.Now,
                    Updated_at = DateTime.Now,
                    IsDeleted = false,
                });

            modelBuilder.Entity<AppUser>().HasData(
                new AppUser()
                {
                    Id = userId,
                    Username = "root",
                    Email = "root@gmail.com",
                    FirstName = "root",
                    LastName = "",
                    FullName = "root",
                    Gender = 0,
                    IdentityCard = "206380988",
                    RoleId = roleId,
                    Password = "$2a$12$WWgvNkyp.9Yr2dWS1mv.f.k/jqoAoxzrwzup9BZviJYryA7SnKgDy", // Password is Abc123!@#
                    IsDeleted = false,
                    JoinedDate = DateTime.Now,
                    Created_at = DateTime.Now,
                    Updated_at = DateTime.Now

                }
                );
        }
    }
}
