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
    public class ActivityManager : IActivityService
    {
        IActivityDal _activityDal;

        public ActivityManager(IActivityDal activityDal)
        {
            _activityDal = activityDal;
        }

        public void TAdd(Activity t)
        {
            _activityDal.Insert(t);
        }

        public void TDelete(Activity t)
        {
            _activityDal.Delete(t);
        }

        public Activity TGetById(int id)
        {
            return _activityDal.GetById(id);
        }

        public List<Activity> TGetList()
        {
            return _activityDal.GetList();
        }

        public void TUpdate(Activity t)
        {
            _activityDal.Update(t);
        }
    }
}
