namespace BookingApp.Data.Entities;

public class FeatureEntity : BaseEntity
{
    public string Title { get; set; }

    // Relation Property
    public ICollection<HotelFeatureEntity> HotelFeatures { get; set; }
}
