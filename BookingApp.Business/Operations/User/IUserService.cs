using BookingApp.Business.Operations.User.Dtos;
using BookingApp.Business.Types;

namespace BookingApp.Business.Operations.User
{
    public interface IUserService
    {
        // async çünkü unit of work kullanılacak
        Task<ServiceMessage> AddUser(AddUserDto user);
    }
}
