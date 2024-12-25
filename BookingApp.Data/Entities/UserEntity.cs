using BookingApp.Data.Enums;

namespace BookingApp.Data.Entities;

public class UserEntity : BaseEntity
{
    public string Email { get; set; }
    public string Password { get; set; }
    public string Firstname { get; set; }
    public string Lastname { get; set; }
    public DateTime BirthDate { get; set; }
    public UserType UserType { get; set; }

    // Relation Property
    public ICollection<ReservationEntity> Reservations { get; set; }
}
