using Insurance.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insurance.Interface
{
    interface ICustomerRepository
    {
        int GetByUserLogin(Customer customer);
    }
}
