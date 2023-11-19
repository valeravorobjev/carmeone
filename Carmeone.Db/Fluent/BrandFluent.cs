using Carmeone.Db.Entities;
using Microsoft.EntityFrameworkCore;

namespace Carmeone.Db.Fluent;

public static class BrandFluent
{
    public static ModelBuilder Brand(this ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Brand>(brand =>
        {
            brand.ToTable(t => t.HasComment("Брэнд (Мерседес, Ауди, и т.д."));

            brand
                .HasMany(b => b.BrandModels)
                .WithOne(b => b.Brand)
                .HasForeignKey(b => b.BrandId);
        });

        return modelBuilder;
    }
}