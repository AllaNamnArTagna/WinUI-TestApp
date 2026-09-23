
using System;
using System.Collections.Generic;
using WinUI_TestApp.Application.Interfaces.Customers;
using WinUI_TestApp.Domain.Models.Customers;

namespace WinUI_TestApp.Infrastructure.Repositories.Customers;

//För att fejka en databas skapar vi en statisk lista som håller alla kunder.
public class ListofCustomers
{
    public static List<Customer> CustomerList { get; set; } = new List<Customer>();
}


public class CustomerRepository : ICustomerRepository
{
    public void CreateCustomer(Customer customer)
    {
        ListofCustomers.CustomerList.Add(customer);
    }

    public void DeleteCustomer(Guid customerId)
    {
        Customer customerToDelete = GetCustomerById(customerId);
        if (customerToDelete != null)
        {
            ListofCustomers.CustomerList.Remove(customerToDelete);
        }
    }

    public List<Customer> GetAllCustomers()
    {
        return ListofCustomers.CustomerList;
    }

    public Customer GetCustomerById(Guid customerId)
    {
        foreach (Customer customer in ListofCustomers.CustomerList)
        {
            if (customerId == customer.CustomerId)
            {
                return customer;
            }
        }
        throw new ArgumentException("Customer not found");
    }

    public void UpdateCustomer(Guid customerId, string newCustomerName, string newCustomerEmail)
    {
        Customer customerToBeUpdated = GetCustomerById(customerId);
        if (customerToBeUpdated != null)
        {
            customerToBeUpdated.CustomerName = newCustomerName;
            customerToBeUpdated.CustomerEmail = newCustomerEmail;
        }
        else
        {
            throw new ArgumentException("Customer not found");
        }
    }
}