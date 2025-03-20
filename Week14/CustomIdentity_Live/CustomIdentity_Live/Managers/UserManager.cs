using CustomIdentity_Live.Context;
using CustomIdentity_Live.Dtos;
using CustomIdentity_Live.Entities;
using CustomIdentity_Live.Services;
using CustomIdentity_Live.Types;

namespace CustomIdentity_Live.Managers
{
    public class UserManager : IUserService
    {
        private readonly IdentityDbContext _context;

        public UserManager(IdentityDbContext context)
        {
            _context = context;
        }
        public async Task<ServiceMessage> AddUser(AddUserDto user)
        {
            var entity = new UserEntity
            {
                Email = user.Email,
                Password = user.Password,
            };

            _context.Users.Add(entity);
            _context.SaveChanges();

            return new ServiceMessage
            {
                IsSucceed = true,
                Message = "Kullanıcı oluşturuldu."
            };
        }
    }
}
