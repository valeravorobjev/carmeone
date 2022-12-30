using Carmeone.Db.Entities;
using Microsoft.EntityFrameworkCore;

namespace Carmeone.Db.Fluent;

/// <summary>
/// Настройка сущьности
/// </summary>
public static class UserPublicationFluent
{
    /// <summary>
    /// Настройка связи многи ко многим между публикацией и пользователем
    /// </summary>
    /// <param name="modelBuilder"></param>
    /// <returns></returns>
    public static ModelBuilder UserPublication(this ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<UserPublication>(up =>
        {
            up.ToTable(t => { t.HasComment("Связь многие ко многим между пользователями и публикациями"); });

            up.Property(p => p.PublicationId).HasComment("Идентификатор публикации");
            up.Property(p => p.UserId).HasComment("Идентификатор пользователя");
        });

        modelBuilder
            .Entity<User>()
            .HasMany<Publication>(m => m.Publications)
            .WithMany(m => m.Users)
            .UsingEntity<UserPublication>(m =>
            {
                m.HasOne(o => o.User)
                    .WithMany(o => o.UserPublications)
                    .HasForeignKey(o => o.UserId);

                m.HasOne(o => o.Publication)
                    .WithMany(o => o.UserPublications)
                    .HasForeignKey(o => o.PublicationId);
            });

        return modelBuilder;
    }
}