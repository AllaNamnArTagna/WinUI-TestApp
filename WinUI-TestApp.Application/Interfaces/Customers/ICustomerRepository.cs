
using System;
using System.Collections.Generic;
using WinUI_TestApp.Domain.Models.Customers;

namespace WinUI_TestApp.Application.Interfaces.Customers;
public interface ICustomerRepository
{
//----------- Create ----------- 

    //Lägg till i listan
    public void CreateCustomer(Customer customer);

//----------- Read ----------- 

    //Hämta kund med id
    public Customer GetCustomerById(Guid customerId);

    public List<Customer> GetAllCustomers();


    //----------- Update ----------- 

    //Uppdatera - hitta kund, ändra värden och spara igen
    public void UpdateCustomer(Customer customer);

//----------- Delete -----------

    //Ta bort customer med hjälp av ID
    public void DeleteCustomer(Guid customerId);

}
