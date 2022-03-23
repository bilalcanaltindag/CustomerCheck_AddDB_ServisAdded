using CustomerCheck_AndDB.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerCheck_AndDB.Abstract
{
    public interface ICustomerService
    {
        void Save(Customer customer);
    }
}
