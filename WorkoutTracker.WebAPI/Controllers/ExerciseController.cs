using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using WorkoutTracker.Core.Models;
using WorkoutTracker.Core.Services;

namespace WorkoutTracker.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExerciseController : ControllerBase
    {
        private readonly IExerciseService _exerciseService;

        public ExerciseController(IExerciseService exerciseService)
        {
            _exerciseService = exerciseService;
        }

        // GET: api/Exercise
        [HttpGet]
        public IEnumerable<Exercises> Get()
        {
            return _exerciseService.GetExercises();
        }

        // GET: api/Exercise/5
        [HttpGet("{id}", Name = "GetExercise")]
        public Exercises Get(int id)
        {
            return _exerciseService.GetExercise(id);
        }

        // POST: api/Exercise
        [HttpPost]
        public void Post([FromBody]Exercises exercise)
        {
            _exerciseService.CreateExercise(exercise);
        }

        // PUT: api/Exercise
        [HttpPut]
        public void Put([FromBody] Exercises exercise)
        {
            _exerciseService.UpdateExercise(exercise);
        }

        // DELETE: api/Exercise/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _exerciseService.DeleteExercise(id);
        }
    }
}
