using System.Collections.Generic;
using WorkoutTracker.Core.Models;

namespace WorkoutTracker.Core.Services
{
    public interface IExerciseService
    {
        void CreateExercise(Exercises exercise);
        void DeleteExercise(int id);
        Exercises GetExercise(int id);
        IEnumerable<Exercises> GetExercises();
        void UpdateExercise(Exercises exercise);
    }
}