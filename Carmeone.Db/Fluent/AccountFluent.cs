using Carmeone.Db.Entities;
using Microsoft.EntityFrameworkCore;

namespace Carmeone.Db.Fluent;

public static class AccountFluent
{
    public static ModelBuilder Account(this ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Account>(account =>
        {
            account.ToTable("accounts", t => { t.HasComment("Аккаунт пользователя"); });

            account
                .HasOne(p => p.User)
                .WithOne(p => p.Account)
                .HasForeignKey<User>(p => p.UserId);

            account
                .Property(p => p.AccountId)
                .HasColumnName("account_id")
                .HasColumnType("uuid")
                .HasDefaultValueSql("uuid_generate_v4()")
                .IsRequired()
                .HasComment("Идентификатор");

            account
                .Property(a => a.Login)
                .HasColumnName("login")
                .HasColumnType("varchar")
                .IsRequired()
                .HasComment("Логин пользователя");

            account
                .Property(a => a.Password)
                .HasColumnName("password")
                .HasColumnType("varchar")
                .IsRequired()
                .HasComment("Пароль (зашифрован)");

            account
                .Property(a => a.Salt)
                .HasColumnName("salt")
                .HasColumnType("integer")
                .IsRequired()
                .HasComment("Соль, первичная. К этой соли подмешивается специальный код.");

            account
                .Property(a => a.Email)
                .HasColumnName("email")
                .HasColumnType("varchar")
                .IsRequired()
                .HasComment("Почтовый адрес");
        });

        return modelBuilder;
    }
}