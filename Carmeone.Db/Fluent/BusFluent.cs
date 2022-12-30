using Carmeone.Db.Entities;
using Microsoft.EntityFrameworkCore;

namespace Carmeone.Db.Fluent;

public static class BusFluent
{
    public static ModelBuilder Bus(this ModelBuilder modelBuilder)
    {

        modelBuilder.Entity<Bus>(bus =>
        {
            bus.ToTable("buses", t => { t.HasComment("Автобус"); });
            
            bus
                .Property(p => p.BusId)
                .HasColumnType("uuid")
                .HasDefaultValueSql("uuid_generate_v4()")
                .IsRequired()
                .HasComment("Идентификатор");
            
            bus
                .Property(a => a.BusType)
                .IsRequired()
                .HasComment("Тип автобуса");
        });
        
        return modelBuilder;
    }
}