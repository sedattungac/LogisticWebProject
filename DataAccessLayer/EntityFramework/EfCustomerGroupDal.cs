using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repository;
using EntityLayer.Entity;

namespace DataAccessLayer.EntityFramework
{
    public class EfCustomerGroupDal:GenericRepository<CustomerGroup>,ICustomerGroupDal
    {
        public EfCustomerGroupDal(Context context) : base(context)
        {
        }
    }
}
