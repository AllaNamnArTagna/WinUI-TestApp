using System;

namespace WinUI_TestApp.Domain.Models.Customers;
public class Customer 
    (
    string customerName,
    string customerEmail,
    Guid customerId
    )
{
    public string CustomerName { get; set; } = customerName;
    public string CustomerEmail { get; set; } = customerEmail;
    public Guid CustomerId { get; set; } = customerId;
}
