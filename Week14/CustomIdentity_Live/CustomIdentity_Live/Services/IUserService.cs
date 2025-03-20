using CustomIdentity_Live.Dtos;
using CustomIdentity_Live.Types;

namespace CustomIdentity_Live.Services
{
    public interface IUserService
    {
        // Geriye hem bool, hem string dönmek istiyorum -> Bir propertysi bool, diğeri string olan bir class oluşturur, onu geri dönerim.
        // Task -> Asenkron olduğu için.
        Task<ServiceMessage> AddUser(AddUserDto user);
    }
}
