using BookingApp.Data.Enums;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BookingApp.Data.Entities;

public class UserEntity : BaseEntity
{
    public string Email { get; set; }
    public string Password { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateTime BirthDate { get; set; }
    public UserType UserType { get; set; }

    // Relation Property
    public ICollection<ReservationEntity> Reservations { get; set; }
}

public class UserConfiguration : BaseConfiguration<UserEntity>
{
    public override void Configure(EntityTypeBuilder<UserEntity> builder)
    {
        builder.Property(x => x.FirstName)
               .IsRequired()
               .HasMaxLength(40);

        builder.Property(x => x.LastName)
               .IsRequired()
               .HasMaxLength(40);

        base.Configure(builder);
    }
}
