using Carmeone.Db.Entities;
using Microsoft.EntityFrameworkCore;

namespace Carmeone.Db.Fluent;

public static class VehicleFluent
{
    public static ModelBuilder Vehicle(this ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Vehicle>(vehicle =>
        {
            vehicle.ToTable(t => { t.HasComment("Транспортные средства"); });

            vehicle
                .HasOne(p => p.Car)
                .WithOne(p => p.Vehicle)
                .HasForeignKey<Car>(p => p.CarId);

            vehicle
                .HasOne(p => p.Bus)
                .WithOne(p => p.Vehicle)
                .HasForeignKey<Bus>(p => p.BusId);
            
            vehicle
                .HasOne(p => p.Moto)
                .WithOne(p => p.Vehicle)
                .HasForeignKey<Moto>(p => p.MotoId);

            vehicle
                .Property(p => p.VehicleId)
                .HasColumnType("uuid")
                .HasDefaultValueSql("uuid_generate_v4()")
                .IsRequired()
                .HasComment("Идентификатор");
            
            vehicle
                .Property(p => p.VehicleType)
                .HasConversion<string>()
                .HasColumnType("varchar")
                .IsRequired()
                .HasComment("Тип транспортного средства");
            
            vehicle
                .Property(p => p.IsNew)
                .IsRequired()
                .HasComment("Новый или подержанный автомобиль");
            
            vehicle
                .Property(p => p.OwnersCount)
                .HasComment("Количество владельцев");
            
            vehicle
                .Property(p => p.YearManufacture)
                .HasComment("Год выпуска");
            
            vehicle
                .Property(p => p.SerialNumber)
                .HasComment("Серийный номер");
            
            vehicle
                .Property(p => p.Mileage)
                .HasComment("Пробег");
            
            vehicle
                .Property(p => p.Cost)
                .HasComment("Стоимость");
            
            vehicle
                .Property(p => p.Power)
                .HasComment("Мощьность кВт");
            
            vehicle
                .Property(p => p.ColorType)
                .HasConversion<string>()
                .HasColumnType("varchar")
                .HasComment("Цвет");
            
            vehicle
                .Property(p => p.IsMetalic)
                .HasComment("Металик или нет");
            
            vehicle
                .Property(p => p.EngineType)
                .HasConversion<string>()
                .HasColumnType("varchar")
                .HasComment("Тип двигателя");
            
            vehicle
                .Property(p => p.TransmissionType)
                .HasConversion<string>()
                .HasColumnType("varchar")
                .HasComment("Тип коробки передач");
            
            vehicle
                .Property(p => p.EngineCapacity)
                .HasComment("Объем двигателя");
            
            vehicle
                .Property(p => p.Photos)
                .HasComment("Фотографии");
            
            vehicle
                .Property(p => p.PhotoOrders)
                .HasComment("Порядок следования фотографий");
            
            vehicle
                .Property(p => p.VehicleStateType)
                .HasConversion<string>()
                .HasColumnType("varchar")
                .HasComment("Состояние транспортного средства");
            
            vehicle
                .Property(p => p.FuelConsumption)
                .HasComment("Расход топлива на 100 км");
            
            vehicle
                .Property(p => p.EnvironmentalSafetyType)
                .HasConversion<string>()
                .HasColumnType("varchar")
                .HasComment("Класс экологической безопасности");
            
            vehicle
                .Property(p => p.EfficiencyClass)
                .HasComment("Эфективность выбросов СО");

            vehicle
                .Property(p => p.Photos)
                .HasComment("Фотографии");
            
            vehicle
                .Property(p => p.Photos)
                .HasComment("Фотографии");

        });

        return modelBuilder;
    }
}