using Business.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class StarbucksCustomerManager : BaseCustomerManager
    {
        ICustomerCheckService _customerCheckService;

        public StarbucksCustomerManager(ICustomerCheckService customerCheckService)
        {
            _customerCheckService = customerCheckService;
        }

        public override void Add(Customer customer)
        {
            
            if (_customerCheckService.CheckIfRealCustomer(customer))
            {
                base.Add(customer);
            }
            else
            {
                throw new Exception("Böyle bir müşteri yok");
            }
            
            
        }
    }
}
