using System.Collections.Generic;
using WorkoutTracker.Core.Models;

namespace WorkoutTracker.Core.Services
{
    public class WorkoutItemService : IWorkoutItemService
    {
        public IEnumerable<WorkoutItem> GetWorkoutItems()
        {
            return new List<WorkoutItem>();
        }

        public WorkoutItem GetWorkoutItem(int id)
        {
            return new WorkoutItem();
        }

        public void CreateWorkoutItem(WorkoutItem workoutItem)
        {

        }

        public void UpdateWorkoutItem(WorkoutItem workoutItem)
        {

        }

        public void DeleteWorkoutItem(int id)
        {

        }
    }
}
