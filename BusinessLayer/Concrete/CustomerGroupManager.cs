using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CustomerGroupManager : ICustomerGroupService
    {
        ICustomerGroupDal _customerGroupDal;

        public CustomerGroupManager(ICustomerGroupDal customerGroupDal)
        {
            _customerGroupDal = customerGroupDal;
        }

        public void TAdd(CustomerGroup t)
        {
            _customerGroupDal.Insert(t);
        }

        public void TDelete(CustomerGroup t)
        {
            _customerGroupDal.Delete(t);
        }

        public CustomerGroup TGetById(int id)
        {
            return _customerGroupDal.GetById(id);
        }

        public List<CustomerGroup> TGetList()
        {
            return _customerGroupDal.GetList();
        }

        public void TUpdate(CustomerGroup t)
        {
            _customerGroupDal.Update(t);
        }
    }
}
