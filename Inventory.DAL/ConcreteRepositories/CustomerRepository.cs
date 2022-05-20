﻿using Inventory.DAL.Context;
using Inventory.Domain.Abstractions;

namespace Inventory.DAL.ConcreteRepositories
{
    public class CustomerRepository : CommonRepository, ICustomerRepository
    {
        public CustomerRepository(InventoryDbContext inventoryDbContext) : base(inventoryDbContext)
        {
        }


        // Implements methods to the Customer repository
    }
}