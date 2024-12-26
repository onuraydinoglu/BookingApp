using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BookingApp.Data.Entities;

public class HotelFeatureEntity : BaseEntity
{
    public int HotelId { get; set; }
    public int FeatureId { get; set; }

    // Relation Property
    public HotelEntity Hotel { get; set; }
    public FeatureEntity Feature { get; set; }
}

public class HotelFeatureConfiguration : BaseConfiguration<HotelFeatureEntity>
{
    public override void Configure(EntityTypeBuilder<HotelFeatureEntity> builder)
    {   
        // Id propertysi görmezden geldik, tabloya aktarılmayacak.
        builder.Ignore(x => x.Id);

        // Composite key oluşturup yeni Primary Key olarak atadık.
        builder.HasKey("HotelId", "FeatureId"); 

        base.Configure(builder);
    }
}
