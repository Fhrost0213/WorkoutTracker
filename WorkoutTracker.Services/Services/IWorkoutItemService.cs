using System.Collections.Generic;
using WorkoutTracker.Core.Models;

namespace WorkoutTracker.Core.Services
{
    public interface IWorkoutItemService
    {
        void CreateWorkoutItem(WorkoutItem workoutItem);
        void DeleteWorkoutItem(int id);
        WorkoutItem GetWorkoutItem(int id);
        IEnumerable<WorkoutItem> GetWorkoutItems();
        void UpdateWorkoutItem(WorkoutItem workoutItem);
    }
}