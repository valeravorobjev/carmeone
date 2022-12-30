using Carmeone.Db.Entities;
using Microsoft.EntityFrameworkCore;

namespace Carmeone.Db.Fluent;

public static class CarFluent
{
    public static ModelBuilder Car(this ModelBuilder modelBuilder)
    {

        modelBuilder.Entity<Car>(car =>
        {
            car.ToTable("cars", t => { t.HasComment("Легковой автомобиль"); });
            
            car
                .Property(p => p.CarId)
                .HasColumnType("uuid")
                .HasDefaultValueSql("uuid_generate_v4()")
                .IsRequired()
                .HasComment("Идентификатор");
            
            car
                .Property(a => a.CarType)
                .IsRequired()
                .HasComment("Тип транспортного средства");
            
            car
                .Property(a => a.SeatsCount)
                .HasComment("Количество сидений");
            
            car
                .Property(a => a.DorsCount)
                .HasComment("Количество дверей");
            
            car
                .Property(a => a.CarInteriorType)
                .HasComment("Тип салона автомобиля");
            
            
        });
        
        return modelBuilder;
    }
}