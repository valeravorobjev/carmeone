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
                .HasOne(p => p.Company)
                .WithOne(p => p.Account)
                .HasForeignKey<Company>(p => p.CompanyId);

            account
                .Property(p => p.AccountId)
                .HasColumnType("uuid")
                .HasDefaultValueSql("uuid_generate_v4()")
                .IsRequired()
                .HasComment("Идентификатор");

            account
                .Property(a => a.Email)
                .HasColumnType("varchar")
                .IsRequired()
                .HasComment("Почтовый адрес");

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
                .Property(a => a.IsActive)
                .HasColumnType("bool")
                .IsRequired()
                .HasComment("Активен аккаунт или нет");
            
            account
                .Property(a => a.ActivationCode)
                .HasColumnType("uuid")
                .IsRequired()
                .HasComment("Код активации. Отправляется по email для подтверждения регистрации.");
            
            account
                .Property(a => a.RegistrationDate)
                .HasColumnName("registration_date")
                .IsRequired()
                .HasComment("Дата регистрации");

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