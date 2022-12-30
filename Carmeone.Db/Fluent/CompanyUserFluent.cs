using Carmeone.Db.Entities;
using Microsoft.EntityFrameworkCore;

namespace Carmeone.Db.Fluent;

public static class CompanyUserFluent
{
    public static ModelBuilder CompanyUser(this ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<CompanyUser>(user =>
        {
            user.ToTable(t => { t.HasComment("Пользователь - компания"); });

            user
                .Property(p => p.CompanyUserId)
                .HasColumnType("uuid")
                .HasDefaultValueSql("uuid_generate_v4()")
                .IsRequired()
                .HasComment("Идентификатор");

        });

        return modelBuilder;
    }
}