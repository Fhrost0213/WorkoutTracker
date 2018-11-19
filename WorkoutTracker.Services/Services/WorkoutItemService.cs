using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using WorkoutTracker.Core.Models;

namespace WorkoutTracker.Core.Services
{
    public class WorkoutItemService : IWorkoutItemService
    {
        private readonly WorkoutTrackerContext _context;

        public WorkoutItemService(WorkoutTrackerContext context)
        {
            _context = context;
        }

        public IEnumerable<WorkoutItems> GetWorkoutItems()
        {
            return _context.WorkoutItems;
        }

        public WorkoutItems GetWorkoutItem(int workoutItemId)
        {
            return _context.WorkoutItems.SingleOrDefault(x => x.WorkoutItemId == workoutItemId);
        }

        public void CreateWorkoutItem(WorkoutItems workoutItem)
        {
            var exercise = _context.Exercises.Find(workoutItem.Exercise.ExerciseId);
            workoutItem.Exercise = exercise;
            _context.WorkoutItems.Add(workoutItem);
            _context.SaveChanges();
        }

        public void UpdateWorkoutItem(WorkoutItems workoutItem)
        {
            var currentWorkoutItem = _context.WorkoutItems.First(x => x.WorkoutItemId == workoutItem.WorkoutItemId);

            if (currentWorkoutItem != null)
            {
                currentWorkoutItem.Exercise = workoutItem.Exercise;
                currentWorkoutItem.Reps = workoutItem.Reps;
                currentWorkoutItem.Weight = workoutItem.Weight;
                currentWorkoutItem.AddDate = workoutItem.AddDate;
                _context.SaveChanges();
            }
        }

        public void DeleteWorkoutItem(int workoutItemId)
        {
            var workoutItem = _context.WorkoutItems.SingleOrDefault(x => x.WorkoutItemId == workoutItemId);

            if (workoutItem != null)
            {
                _context.WorkoutItems.Remove(workoutItem);
                _context.SaveChanges();
            }
        }
    }
}
