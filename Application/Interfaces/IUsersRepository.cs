﻿using Server.Application.Models;

namespace Server.Application.Interfaces
{
    public interface IUsersRepository
    {
        Task<IEnumerable<User>> GetUserListsAsync();
        Task<Customer?> GetCustomerAsync(int customerID);
        Task<User?> GetAdminAsync(int adminID);
        Task CreateAdminAsync(User admin);
        Task CreateCustomerAsync(Customer customer);
        Task<bool> IsEmailExisting(string email);
        Task<User?> LoginUserAsync(string email);
    }
}
