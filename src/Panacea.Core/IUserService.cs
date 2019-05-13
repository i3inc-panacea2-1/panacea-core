using System;
using System.Threading.Tasks;

namespace Panacea.Core
{
    public interface IUserService
    {
        event UserEvent UserLoggedIn;

        event UserEvent UserLoggedOut;

        IUser User { get; }

        Task LogoutAsync();

        Task<bool> LoginAsync(DateTime dateOfBirth, string password);

        Task<bool> LoginAsync(string email, string password);

        Task<bool> LoginAsync(string cardId);
    }

    public delegate Task UserEvent(IUser user);

}
