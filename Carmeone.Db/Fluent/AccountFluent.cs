using Carmeone.Db.Entities;
using Microsoft.EntityFrameworkCore;

namespace Carmeone.Db.Fluent;

public static class AccountFluent
{
    public static ModelBuilder Account(this ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Account>(account =>
        {
            account.ToTable(t => { t.HasComment("Аккаунт пользователя"); });

            account
                .HasOne(p => p.User)
                .WithOne(p => p.Account)
                .HasForeignKey<User>(p => p.UserId);

            account
                .Property(p => p.AccountId)
                .HasColumnType("uuid")
                .HasDefaultValueSql("uuid_generate_v4()")
                .IsRequired()
                .HasComment("Идентификатор");

            account
                .Property(a => a.Login)
                .HasColumnType("varchar")
                .IsRequired()
                .HasComment("Логин пользователя");

            account
                .Property(a => a.Password)
                .HasColumnType("varchar")
                .IsRequired()
                .HasComment("Пароль (зашифрован)");

            account
                .Property(a => a.Salt)
                .HasColumnType("integer")
                .IsRequired()
                .HasComment("Соль, первичная. К этой соли подмешивается специальный код.");

            account
                .Property(a => a.Email)
                .HasColumnType("varchar")
                .IsRequired()
                .HasComment("Почтовый адрес");
            
            account
                .Property(a => a.AccountRole)
                .HasConversion<string>()
                .HasColumnType("varchar")
                .IsRequired()
                .HasComment("Почтовый адрес");
        });

        return modelBuilder;
    }
}