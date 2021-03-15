using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstact
{
    interface ICustomerDal:IEntityRepository<Customer>
    {
    }
}
