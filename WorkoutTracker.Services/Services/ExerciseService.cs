using System.Collections.Generic;
using System.Linq;
using WorkoutTracker.Core.Models;

namespace WorkoutTracker.Core.Services
{
    public class ExerciseService : IExerciseService
    {
        private static readonly List<Exercise> _exercises = new List<Exercise>();

        public IEnumerable<Exercise> GetExercises()
        {
            return _exercises;
        }

        public Exercise GetExercise(int id)
        {
            return _exercises.FirstOrDefault(x => x.Id == id);
        }

        public void CreateExercise(Exercise exercise)
        {
            _exercises.Add(exercise);
        }

        public void UpdateExercise(Exercise exercise)
        {
            var currentExercise = _exercises.First(x => x.Id == exercise.Id);

            if (currentExercise != null)
            {
                currentExercise.Description = exercise.Description;
                currentExercise.Name = exercise.Name;
            }
        }

        public void DeleteExercise(int id)
        {
            var exercise = _exercises.FirstOrDefault(x => x.Id == id);

            _exercises.Remove(exercise);
        }
    }
}
