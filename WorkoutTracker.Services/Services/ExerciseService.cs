using System.Collections.Generic;
using System.Linq;
using WorkoutTracker.Core.Models;

namespace WorkoutTracker.Core.Services
{
    public class ExerciseService : IExerciseService
    {
        private readonly WorkoutTrackerContext _context;

        public ExerciseService(WorkoutTrackerContext context)
        {
            _context = context;
        }

        public IEnumerable<Exercises> GetExercises()
        {
            return _context.Exercises;
        }

        public Exercises GetExercise(int id)
        {
            return _context.Exercises.SingleOrDefault(x => x.ExerciseId == id);
        }

        public void CreateExercise(Exercises exercise)
        {
            _context.Exercises.Add(exercise);
            _context.SaveChanges();
        }

        public void UpdateExercise(Exercises exercise)
        {
            var currentExercise = _context.Exercises.SingleOrDefault(x => x.ExerciseId == exercise.ExerciseId);

            if (currentExercise != null)
            {
                currentExercise.ExerciseDescription = exercise.ExerciseDescription;
                currentExercise.ExerciseName = exercise.ExerciseName;
                _context.SaveChanges();
            }
        }

        public void DeleteExercise(int exerciseId)
        {
            var exercise = _context.Exercises.SingleOrDefault(x => x.ExerciseId == exerciseId);

            if (exercise != null)
            {
                _context.Exercises.Remove(exercise);
                _context.SaveChanges();
            }
                
        }
    }
}
