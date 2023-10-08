using DataAccessLayer.Concrete;
using EntityLayer.Entity;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace WebApiLayer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ActivityController : ControllerBase
    {
        private readonly Context _context;

        public ActivityController(Context context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult ActivityList()
        {
            var values = _context.Activities.ToList();
            return Ok(values);
        }
        [HttpGet("{id}")]
        public IActionResult GetByIdActivity(int id)
        {
            var activityId = _context.Activities.Where(x => x.ActivityId == id).ToList();
            return Ok(activityId);
        }
        [HttpPost]
        public IActionResult AddActivity(Activity activity)
        {
            _context.Add(activity);
            _context.SaveChanges();
            return Ok();
        }

        [HttpPut]
        public IActionResult EditActivity(Activity activity)
        {
            var activityId = _context.Activities.Find(activity.ActivityId);
            if (activityId == null)
            {
                return NotFound();
            }
            else
            {
                activityId.Description = activity.Description;
                activityId.Title = activity.Title;
                _context.Update(activityId);
                _context.SaveChanges();
            }
            return Ok();
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteActivity(int id)
        {
            var activityId = _context.Activities.Find(id);
            _context.Remove(activityId);
            _context.SaveChanges();
            return Ok();
        }
    }
}
