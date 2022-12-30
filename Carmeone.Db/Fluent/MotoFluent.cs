using Carmeone.Db.Entities;
using Microsoft.EntityFrameworkCore;

namespace Carmeone.Db.Fluent;

public static class MotoFluent
{
    public static ModelBuilder Moto(this ModelBuilder modelBuilder)
    {

        modelBuilder.Entity<Moto>(moto =>
        {
            moto.ToTable("motos", t => { t.HasComment("Мотоцикл"); });
            
            moto
                .Property(p => p.MotoId)
                .HasColumnType("uuid")
                .HasDefaultValueSql("uuid_generate_v4()")
                .IsRequired()
                .HasComment("Идентификатор");
            
            moto
                .Property(a => a.MotoType)
                .IsRequired()
                .HasComment("Тип мотоцикла");
        });
        
        return modelBuilder;
    }
}