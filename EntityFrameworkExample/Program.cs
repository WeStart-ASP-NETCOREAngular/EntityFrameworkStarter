// See https://aka.ms/new-console-template for more information
using EntityFrameworkExample.Data;

Console.WriteLine("Hello, World!");


using (ExampleDbContext context = new ExampleDbContext())
{
    context.customers.Add(new Customer { Name = "Test" });
    context.SaveChanges();
    var customers = context.customers.ToList();
    foreach (var customer in customers)
    {
        Console.Write(customer.Name);   
    }
}