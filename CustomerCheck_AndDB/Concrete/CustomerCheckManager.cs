using CustomerCheck_AndDB.Abstract;
using CustomerCheck_AndDB.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerCheck_AndDB.Concrete
{
    public class CustomerCheckManager : ICustomerCheckService
    {
        public bool CheckIfRealPerson(Customer customer)
        {
                return true;
        }
    }
}
