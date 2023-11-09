using LeaveManagement.web.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeaveManagement.web.Configurations.Entities
{
    public class UserSeedConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            var hasher = new PasswordHasher<Employee>();
            builder.HasData(
                new Employee
                {
                    Id = "d2a475a0-482e-461e-876a-ad906172dfdb",
                    Email = "admin@test.com",
                    NormalizedEmail = "ADMIN@TEST.COM",
                    FirstName = "Sys",
                    LastName = "Admin",
                    PasswordHash = hasher.HashPassword(null, "a")
                },
                new Employee
                {
                    Id = "b20b4d78-e4bf-4cbd-9e1e-e2395464de28",
                    Email = "user@test.com",
                    NormalizedEmail = "USER@TEST.COM",
                    FirstName = "Sys",
                    LastName = "User",
                    PasswordHash = hasher.HashPassword(null, "a")
                });
        }
    }
}