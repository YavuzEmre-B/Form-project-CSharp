using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project3
{
    internal class CustomerManager
    {
        public CustomerManager()
        {
            customers = new List<Customer>()
            {
                new Customer{Id=1, FirstName="Emre", LastName="Baycan", City="Bursa", Email="emre@gmail.com"},
                new Customer{Id=1, FirstName="Ali", LastName="Dindar", City="Denizli", Email="ali@gmail.com"},
                new Customer{Id=1, FirstName="Asaf", LastName="Tekin", City="Bilecik", Email="asaf@gmail.com"},
                new Customer{Id=1, FirstName="Furkan", LastName="Acikgoz", City="Bursa", Email="furkan@gmail.com"},
                new Customer{Id=1, FirstName="Baris", LastName="Cirika", City="Ankara", Email="baris@gmail.com"}
            };
        }

        List<Customer> customers;

        public List<Customer> GetAll()
        {
            //Veritabanina baglan
            return customers;
        }

        public void Add(Customer customer)
        {
            customers.Add(customer);
        }
    }
}
