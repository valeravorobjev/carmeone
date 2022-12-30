using Carmeone.Db.Entities;
using Microsoft.EntityFrameworkCore;

namespace Carmeone.Db.Fluent;

public static class IndividualUserFluent
{
    public static ModelBuilder IndividualUser(this ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<IndividualUser>(user =>
        {
            user.ToTable(t => { t.HasComment("Индивидуальный пользователь"); });

            user
                .Property(p => p.IndividualUserId)
                .HasColumnType("uuid")
                .HasDefaultValueSql("uuid_generate_v4()")
                .IsRequired()
                .HasComment("Идентификатор");
            
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

        });

        return modelBuilder;
    }
}