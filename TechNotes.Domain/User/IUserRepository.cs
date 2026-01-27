using System;

namespace TechNotes.Domain.User;

public interface IUserRepository
{
    Task<IUser> GetUserByIdAsync(string userIr);
}
