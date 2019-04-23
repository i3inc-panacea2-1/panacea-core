using System;

namespace Panacea.Core
{
    public interface IUser
    {
        string FirstName { get; }

        string LastName { get; }

        string Email { get; }

        string Id { get; }

        string Password { get; }

        string Telephone { get; }

        DateTime DateOfBirth { get; }

        bool IsAnonymous { get; }
    }
}
