namespace Org.App.DataService
{
    using System.Collections.Generic;
    using Core.Model;
    using System;

    public class AppDbContext  : IDisposable
    {
        private static List<Customer> _customers;

        public List<Customer> Customers => _customers;

        static AppDbContext()
        {
            _customers = new List<Customer>()
            {
                new Customer { Id = 0, FirstName="A", LastName = "B", ZipCode="12345" },
                new Customer { Id = 1, FirstName="B", LastName = "B", ZipCode="12345" },
                new Customer { Id = 2, FirstName="C", LastName = "B", ZipCode="12345" },
                new Customer { Id = 3, FirstName="D", LastName = "B", ZipCode="12345" },
                new Customer { Id = 4, FirstName="E", LastName = "B", ZipCode="12345" },
                new Customer { Id = 5, FirstName="F", LastName = "B", ZipCode="12345" },
                new Customer { Id = 6, FirstName="G", LastName = "B", ZipCode="12345" },
            };


        }

        public void Dispose()
        {
            _customers = null;
        }
    }
}
