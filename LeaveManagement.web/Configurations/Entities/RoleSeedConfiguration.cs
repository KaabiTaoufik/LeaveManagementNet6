using LeaveManagement.web.Constants;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeaveManagement.web.Configurations.Entities
{
    public class RoleSeedConfiguration : IEntityTypeConfiguration<IdentityRole>
    {
        public void Configure(EntityTypeBuilder<IdentityRole> builder)
        {
            builder.HasData(
                new IdentityRole
                {
                    Id = "ebe6352a-a838-44a6-a1d8-a8daaaa5bb50",
                    Name = UserRole.Administrator,
                    NormalizedName = UserRole.Administrator.ToUpper(),
                },
                new IdentityRole
                {
                    Id = "53d14e40-8320-4bea-9bfd-ca3f40a55bc4",
                    Name = UserRole.User,
                    NormalizedName = UserRole.User.ToUpper(),
                });
        }
    }
}