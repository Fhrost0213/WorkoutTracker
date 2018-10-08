using System;

namespace WorkoutTracker.Core.Models
{
    public class WorkoutItem
    {
        public int Id { get; set; }
        public Exercise Exercise { get; set; }
        public int Reps { get; set; }
        public int Weight { get; set; }
        public DateTime AddDate { get; set; }
    }
}
