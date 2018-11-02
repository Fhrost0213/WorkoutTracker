using System.Collections.Generic;
using System.Linq;
using WorkoutTracker.Core.Models;

namespace WorkoutTracker.Core.Services
{
    public class WorkoutItemService : IWorkoutItemService
    {
        private static readonly List<WorkoutItem> _workoutItems = new List<WorkoutItem>();

        public IEnumerable<WorkoutItem> GetWorkoutItems()
        {
            return _workoutItems;
        }

        public WorkoutItem GetWorkoutItem(int id)
        {
            return _workoutItems.FirstOrDefault(x => x.Id == id);
        }

        public void CreateWorkoutItem(WorkoutItem workoutItem)
        {
            _workoutItems.Add(workoutItem);
        }

        public void UpdateWorkoutItem(WorkoutItem workoutItem)
        {
            var currentWorkoutItem = _workoutItems.First(x => x.Id == workoutItem.Id);

            if (currentWorkoutItem != null)
            {
                currentWorkoutItem.Exercise = workoutItem.Exercise;
                currentWorkoutItem.Reps = workoutItem.Reps;
                currentWorkoutItem.Weight = workoutItem.Weight;
                currentWorkoutItem.AddDate = workoutItem.AddDate;
            }
        }

        public void DeleteWorkoutItem(int id)
        {
            var workoutItem = _workoutItems.FirstOrDefault(x => x.Id == id);

            _workoutItems.Remove(workoutItem);
        }
    }
}
