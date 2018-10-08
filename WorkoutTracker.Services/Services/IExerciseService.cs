using System.Collections.Generic;
using WorkoutTracker.Core.Models;

namespace WorkoutTracker.Core.Services
{
    public interface IExerciseService
    {
        void CreateExercise(Exercise exercise);
        void DeleteExercise(int id);
        Exercise GetExercise(int id);
        IEnumerable<Exercise> GetExercises();
        void UpdateExercise(Exercise exercise);
    }
}