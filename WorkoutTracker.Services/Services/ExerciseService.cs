using System.Collections.Generic;
using WorkoutTracker.Core.Models;

namespace WorkoutTracker.Core.Services
{
    public class ExerciseService : IExerciseService
    {
        public IEnumerable<Exercise> GetExercises()
        {
            return new List<Exercise>();
        }

        public Exercise GetExercise(int id)
        {
            return new Exercise();
        }

        public void CreateExercise(Exercise exercise)
        {

        }

        public void UpdateExercise(Exercise exercise)
        {

        }

        public void DeleteExercise(int id)
        {

        }
    }
}
