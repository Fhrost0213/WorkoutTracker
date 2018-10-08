using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using WorkoutTracker.Core.Models;
using WorkoutTracker.Core.Services;

namespace WorkoutTracker.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WorkoutItemController : ControllerBase
    {
        private readonly IWorkoutItemService _workoutItemService;

        public WorkoutItemController(IWorkoutItemService workoutItemService)
        {
            _workoutItemService = workoutItemService;
        }

        // GET: api/WorkoutItem
        [HttpGet]
        public IEnumerable<WorkoutItem> Get()
        {
            return _workoutItemService.GetWorkoutItems();
        }

        // GET: api/WorkoutItem/5
        [HttpGet("{id}", Name = "GetWorkoutItem")]
        public WorkoutItem Get(int id)
        {
            return _workoutItemService.GetWorkoutItem(id);
        }

        // POST: api/WorkoutItem
        [HttpPost]
        public void Post([FromBody]WorkoutItem workoutItem)
        {
            _workoutItemService.CreateWorkoutItem(workoutItem);
        }

        // PUT: api/WorkoutItem
        [HttpPut]
        public void Put([FromBody]WorkoutItem workoutItem)
        {
            _workoutItemService.UpdateWorkoutItem(workoutItem);
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _workoutItemService.DeleteWorkoutItem(id);
        }
    }
}
