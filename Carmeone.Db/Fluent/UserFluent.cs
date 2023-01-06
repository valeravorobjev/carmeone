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
                .Property(a => a.Sity)
                .HasColumnName("sity")
                .HasColumnType("varchar")
                .HasComment("Город");
            
            user
                .Property(p => p.FirstName)
                .HasColumnType("varchar")
                .HasComment("Фамилия");
            
            user
                .Property(p => p.LastName)
                .HasColumnType("varchar")
                .HasComment("Имя");
            
            user
                .Property(p => p.MiddleName)
                .HasColumnType("varchar")
                .HasComment("Отчество");
            
            user
                .Property(p => p.DateBirth)
                .HasComment("Дата рождения");
            
            user
                .Property(a => a.Description)
                .HasColumnName("description")
                .HasColumnType("text")
                .HasComment("Описание");

        });

        return modelBuilder;
    }
}