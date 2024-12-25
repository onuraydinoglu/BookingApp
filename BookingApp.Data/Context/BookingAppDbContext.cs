using BookingApp.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace BookingApp.Data.Context;

public class BookingAppDbContext : DbContext
{
    public BookingAppDbContext(DbContextOptions<BookingAppDbContext> options) : base(options){ }

    public DbSet<UserEntity> Users => Set<UserEntity>();
    public DbSet<FeatureEntity> Features => Set<FeatureEntity>();
    public DbSet<HotelEntity> Hotels => Set<HotelEntity>();
    public DbSet<HotelFeatureEntity> HotelFeatures => Set<HotelFeatureEntity>();
    public DbSet<ReservationEntity> Reservations => Set<ReservationEntity>();
    public DbSet<RoomEntity> Rooms => Set<RoomEntity>();
}
