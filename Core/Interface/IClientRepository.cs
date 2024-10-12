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
        Task<Client> AddClientAsync(Client client);
    }
}
