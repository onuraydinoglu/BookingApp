using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BookingApp.Data.Entities;

public class BaseEntity
{
    //public BaseEntity()
    //{
    //    CreatedDate = DateTime.Now;
    //}

    public int Id { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime? ModifiedDate { get; set; }
    public bool IsDeleted { get; set; }
}

public abstract class BaseConfiguration<TEntity> : IEntityTypeConfiguration<TEntity> where TEntity : BaseEntity
{
    public virtual void Configure(EntityTypeBuilder<TEntity> builder)
    {
        // bütün linq sorgularında geçerli bir filitre
        builder.HasQueryFilter(x => x.IsDeleted == false);

        builder.Property(x => x.ModifiedDate)
            .IsRequired(false);
    }
}
