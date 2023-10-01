using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiLayer.DataAccessLayer.Concrete;
using WebApiLayer.EntityLayer;

namespace WebApiLayer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ActivityController : ControllerBase
    {
        [HttpGet]
        public IActionResult ActivityList()
        {
            using var c = new Context();
            var values = c.Activities.ToList();
            return Ok(values);
        }
        [HttpGet("{id}")]
        public IActionResult GetByIdActivity(int id)
        {
            using var c = new Context();
            var activityId = c.Activities.Where(x => x.ActivityId == id).ToList();
            return Ok(activityId);
        }
        [HttpPost]
        public IActionResult AddActivity(Activity activity)
        {
            using var c = new Context();
            c.Add(activity);
            c.SaveChanges();
            return Ok();
        }

        [HttpPut]
        public IActionResult EditActivity(Activity activity)
        {
            using var c = new Context();
            var activityId = c.Activities.Find(activity.ActivityId);
            if (activityId == null)
            {
                return NotFound();
            }
            else
            {
                activityId.Description = activity.Description;
                activityId.Title = activity.Title;
                c.Update(activityId);
                c.SaveChanges();
            }
            return Ok();
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteActivity(int id)
        {
            using var c = new Context();
            var activityId = c.Activities.Find(id);
            c.Remove(activityId);
            c.SaveChanges();
            return Ok();
        }
    }
}
