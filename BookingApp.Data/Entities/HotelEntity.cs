using BookingApp.Data.Enums;

namespace BookingApp.Data.Entities;

public class HotelEntity : BaseEntity
{
    public string Name { get; set; }
    public int? Stars { get; set; }
    public string Location { get; set; }
    public AccomodationType AccomodationType { get; set; }

    // Relation Property
    public ICollection<HotelFeatureEntity> HotelFeatures { get; set; }
    public ICollection<RoomEntity> Rooms { get; set; }
}
