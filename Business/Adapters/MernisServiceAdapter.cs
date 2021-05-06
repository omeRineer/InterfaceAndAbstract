using Business.Abstract;
using Business.MernisServiceReferance;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Business.Adapters
{
    public class MernisServiceAdapter : ICustomerCheckService
    {
        public bool CheckIfRealCustomer(Customer customer)
        {
            KPSPublicSoapClient kps = new KPSPublicSoapClient();
            return kps.TCKimlikNoDogrula(Convert.ToInt64(customer.NationalityId), customer.FirstName.ToUpper(),
                customer.LastName.ToUpper(), customer.DateOfBirth.Year);

        }
    }
}
