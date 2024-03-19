using WebApplication7.Models;

namespace WebApplication7.Services.Customers
{
    public class CustomerService : ICustomerService
    {
        private readonly List<Customer> _customers = new List<Customer>
        {
            new Customer { Id = 1, Login = "WilliamAfton@gmail.com", Password = "qgstYt87X" },
            new Customer { Id = 2, Login = "SarahJohnson@hotmail.com", Password = "r7Fthk21Z" },
            new Customer { Id = 3, Login = "MichaelDoe@yahoo.com", Password = "p9Gnwq32Y" },
            new Customer { Id = 4, Login = "EmilySmith@gmail.com", Password = "u8Vxfj75K" },
            new Customer { Id = 5, Login = "JessicaBrown@aol.com", Password = "w3Zdmv89L" },
            new Customer { Id = 6, Login = "DavidJones@gmail.com", Password = "t4Cpql67R" },
            new Customer { Id = 7, Login = "JenniferMiller@hotmail.com", Password = "s6Bhzx43M" },
            new Customer { Id = 8, Login = "DanielWilson@yahoo.com", Password = "v2Skow56N" },
            new Customer { Id = 9, Login = "EmmaTaylor@aol.com", Password = "x5Vjyr34O" },
            new Customer { Id = 10, Login = "JamesAnderson@gmail.com", Password = "z1Lncp98P" }
        };

        public async Task<IEnumerable<Customer>> GetCustomers()
        {
            return await Task.FromResult(_customers);
        }

        public async Task AddCustomer(Customer customer)
        {
            _customers.Add(customer);
            await Task.CompletedTask;
        }

        public async Task UpdateCustomer(Customer customer)
        {
            var existingCustomer = _customers.Find(c => c.Id == customer.Id);
            if (existingCustomer != null)
            {
                existingCustomer.Login = customer.Login;
                existingCustomer.Password = customer.Password;
            }
            await Task.CompletedTask;
        }

        public async Task DeleteCustomer(int id)
        {
            _customers.RemoveAll(c => c.Id == id);
            await Task.CompletedTask;
        }
    }
}
