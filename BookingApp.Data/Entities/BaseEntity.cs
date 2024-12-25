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
