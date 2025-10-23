﻿using clean_architecture_dotnet.Domain.Entities.Users;

namespace clean_architecture_dotnet.Infrastructure.Repositories.Users.Interfaces
{
    public interface IUserRepository
    {
        Task<IEnumerable<User>> GetAll();
        Task<User> GetById(int id);
        Task<User> Put(User user);
        Task<User> Post(User user);
        Task<User> Delete(User user);
    }
}
