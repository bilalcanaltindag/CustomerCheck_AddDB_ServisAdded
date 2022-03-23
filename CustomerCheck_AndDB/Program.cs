using CustomerCheck_AndDB.Abstract;
using CustomerCheck_AndDB.Adapters;
using CustomerCheck_AndDB.Concrete;
using CustomerCheck_AndDB.Entities;
using System;

namespace CustomerCheck_AndDB
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer { NationalityId = "28861499108", FirstName = "Engin", LastName = "Demiroğ", DateOfBirth = new DateTime(1985, 1, 6) };

            BaseCustomerManager customerManager1 = new NeroCustomerManager();
            customerManager1.Save(customer1);

            BaseCustomerManager customerManager2 = new StarbucksCustomerManager(new MernisServiceAdapter());
            customerManager1.Save(customer1);
        }
    }
}
