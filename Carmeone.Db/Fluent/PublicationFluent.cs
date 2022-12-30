using Carmeone.Db.Entities;
using Microsoft.EntityFrameworkCore;

namespace Carmeone.Db.Fluent;

public static class PublicationFluent
{
    public static ModelBuilder Publication(this ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Publication>(publication =>
        {
            publication.ToTable(t => { t.HasComment("Публикация"); });

            publication
                .HasMany(p => p.Users)
                .WithMany(p => p.Publications)
                .UsingEntity<UserPublication>(entity =>
                {
                    entity
                        .HasOne(o => o.Publication)
                        .WithMany(o => o.UserPublications)
                        .HasForeignKey(o => o.PublicationId);

                    entity
                        .HasOne(o => o.User)
                        .WithMany(o => o.UserPublications)
                        .HasForeignKey(o => o.UserId);
                });

            publication
                .Property(p => p.PublicationId)
                .HasColumnType("uuid")
                .HasDefaultValueSql("uuid_generate_v4()")
                .IsRequired()
                .HasComment("Идентификатор");

            publication
                .Property(a => a.CreateDate)
                .IsRequired()
                .HasComment("Дата создания объявления");

            publication
                .Property(a => a.ExpirationDate)
                .IsRequired()
                .HasComment("Дата истечения публикации");

            publication
                .Property(a => a.IsAutoRenew)
                .IsRequired()
                .HasComment("Автоматически возобнавлять объявление");

            publication
                .Property(a => a.TargetType)
                .HasConversion<string>()
                .HasColumnType("varchar")
                .IsRequired()
                .HasComment("Цель размещения транспортного средства на площадке");
        });

        return modelBuilder;
    }
}