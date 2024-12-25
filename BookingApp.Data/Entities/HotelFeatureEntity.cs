namespace BookingApp.Data.Entities;

public class HotelFeatureEntity : BaseEntity
{
    public int HotelId { get; set; }
    public int FeatureId { get; set; }

    // Relation Property
    public HotelEntity Hotel { get; set; }
    public FeatureEntity Feature { get; set; }
}
