﻿using MyData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace MyDashboard.Services
{
    public class CustomersRepository : ICustomersRepository
    {
        MyDbContext _context = new MyDbContext();
        public Task<List<Customer>> GetCustomersAsync()
        {
            return _context.Customers.ToListAsync();
        }
        public Task<Customer> GetCustomerAsync(Guid id)
        {
            return _context.Customers.FirstOrDefaultAsync(c => c.Id == id);
        }
        public async Task<Customer> AddCustomerAsync(Customer customer)
        {
            _context.Customers.Add(customer);
            await _context.SaveChangesAsync();
            return customer;
        }
        public async Task<Customer> UpdateCustomerAsync(Customer customer)
        {
            if (!_context.Customers.Local.Any(c => c.Id == customer.Id)) 
            {
                _context.Customers.Attach(customer);
            }
            _context.Entry(customer).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return customer;
        }
        public async Task DeleteCustomerAsync(Guid customerId)
        {
            var customer = _context.Customers.FirstOrDefault(c => c.Id == customerId);
            if (customer != null)
            {
                _context.Customers.Remove(customer);
            }
            await _context.SaveChangesAsync();
        }
        
    }
}
