namespace BookingApp.Data.Entities;

public class ReservationEntity : BaseEntity
{
    public int RoomId { get; set; }
    public int UserId { get; set; }
    public DateTime StratDate { get; set; }
    public DateTime EndTime { get; set; }
    public int GuestCount { get; set; }

    // Relation Property
    public UserEntity User { get; set; }
    public RoomEntity Room { get; set; }
}
