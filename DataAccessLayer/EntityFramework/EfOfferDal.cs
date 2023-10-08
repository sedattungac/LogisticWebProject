using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repository;
using EntityLayer.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EfOfferDal : GenericRepository<Offer>, IOfferDal
    {
        public EfOfferDal(Context context) : base(context)
        {
        }
    }
}
