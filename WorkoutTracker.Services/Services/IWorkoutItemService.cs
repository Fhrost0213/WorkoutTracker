using System.Collections.Generic;
using WorkoutTracker.Core.Models;

namespace WorkoutTracker.Core.Services
{
    public interface IWorkoutItemService
    {
        void CreateWorkoutItem(WorkoutItems workoutItem);
        void DeleteWorkoutItem(int id);
        WorkoutItems GetWorkoutItem(int id);
        IEnumerable<WorkoutItems> GetWorkoutItems();
        void UpdateWorkoutItem(WorkoutItems workoutItem);
    }
}