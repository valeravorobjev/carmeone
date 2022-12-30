using Carmeone.Db.Entities;
using Microsoft.EntityFrameworkCore;

namespace Carmeone.Db.Fluent;

public static class UserFluent
{
    public static ModelBuilder User(this ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<User>(user =>
        {
            user.ToTable(t => { t.HasComment("Пользователь"); });
            
            user
                .HasOne(p => p.CompanyUser)
                .WithOne(p => p.User)
                .HasForeignKey<CompanyUser>(p => p.CompanyUserId);
            
            user
                .HasOne(p => p.IndividualUser)
                .WithOne(p => p.User)
                .HasForeignKey<IndividualUser>(p => p.IndividualUserId);

            user
                .Property(p => p.UserId)
                .HasColumnName("user_id")
                .HasColumnType("uuid")
                .HasDefaultValueSql("uuid_generate_v4()")
                .IsRequired()
                .HasComment("Идентификатор");
            
            user
                .Property(a => a.Avatar)
                .HasColumnName("avatar")
                .HasColumnType("varchar")
                .HasComment("Аватар (картинка)");
            
            user
                .Property(a => a.Phone)
                .HasColumnName("phone")
                .HasColumnType("varchar")
                .HasComment("Телефон");
            
            user
                .Property(a => a.Address)
                .HasColumnName("address")
                .HasColumnType("varchar")
                .HasComment("Адрес");
            
            user
                .Property(a => a.Description)
                .HasColumnName("description")
                .HasColumnType("text")
                .HasComment("Описание");
            
            user
                .Property(a => a.RegistrationDate)
                .HasColumnName("registration_date")
                .IsRequired()
                .HasComment("Дата регистрации");

        });

        return modelBuilder;
    }
}