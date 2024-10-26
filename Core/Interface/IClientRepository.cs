﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interface
{
    public interface IClientRepository
    {
        Task<Client> GetClientByIdAsync(int Id);
        Task<int> AddClientAsync(Client client);
        
        Task<Client?> GetClientByNationalIdAsync(string nationalId);
        Task<Client?> SearchClientAsync(string searchQuery);

        Task<IReadOnlyList<Reservation>> GetReservationsAsync(int clientId);
        Task<IReadOnlyList<Rental>> GetRentalsAsync(int clientId);
        Task<string> GetEmailAsync(int clientId);
        
    }
}
