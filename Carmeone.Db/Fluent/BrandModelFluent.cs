using Carmeone.Db.Entities;
using Microsoft.EntityFrameworkCore;

namespace Carmeone.Db.Fluent;

public static class BrandModelFluent
{
    public static ModelBuilder BrandModel(this ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<BrandModel>(brandModel =>
        {
            brandModel.ToTable(t => t.HasComment("Брэнд модели"));

            brandModel
                .HasOne(b => b.Brand)
                .WithMany(b => b.BrandModels)
                .HasForeignKey(b => b.BrandId)
                .IsRequired();

            brandModel
                .HasMany<Vehicle>(b => b.Vehicles)
                .WithOne(b => b.BrandModel)
                .HasForeignKey(b => b.BrandModelId);
        });

        return modelBuilder;
    }
}