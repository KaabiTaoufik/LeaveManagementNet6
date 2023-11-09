using LeaveManagement.web.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace LeaveManagement.web.Configurations.Entities
{
    public class UserRoleSeedConfiguration : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Microsoft.AspNetCore.Identity.IdentityUserRole<string>> builder)
        {
            builder.HasData(
                new IdentityUserRole<string>
                {
                    RoleId = "ebe6352a-a838-44a6-a1d8-a8daaaa5bb50",
                    UserId = "d2a475a0-482e-461e-876a-ad906172dfdb",
                },
                new IdentityUserRole<string>
                {
                    RoleId = "53d14e40-8320-4bea-9bfd-ca3f40a55bc4",
                    UserId = "b20b4d78-e4bf-4cbd-9e1e-e2395464de28",
                }); 
        }
    }
}