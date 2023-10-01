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
    public class OfferManager : IOfferService
    {
        IOfferDal _offerDal;

        public OfferManager(IOfferDal offerDal)
        {
            _offerDal = offerDal;
        }

        public void TAdd(Offer t)
        {
            _offerDal.Insert(t);
        }

        public void TDelete(Offer t)
        {
            _offerDal.Delete(t);
        }

        public Offer TGetById(int id)
        {
            return _offerDal.GetById(id);
        }

        public List<Offer> TGetList()
        {
            return _offerDal.GetList();
        }

        public void TUpdate(Offer t)
        {
            _offerDal.Update(t);
        }
    }
}
