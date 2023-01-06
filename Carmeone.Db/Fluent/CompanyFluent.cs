using Carmeone.Db.Entities;
using Microsoft.EntityFrameworkCore;

namespace Carmeone.Db.Fluent;

public static class CompanyFluent
{
    public static ModelBuilder Company(this ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Company>(user =>
        {
            user.ToTable(t => { t.HasComment("Пользователь - компания"); });

            user
                .Property(p => p.CompanyId)
                .HasColumnType("uuid")
                .HasDefaultValueSql("uuid_generate_v4()")
                .IsRequired()
                .HasComment("Идентификатор");

        });

        return modelBuilder;
    }
}