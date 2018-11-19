using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace WorkoutTracker.Core.Models
{
    public partial class Exercises
    {
        public Exercises()
        {
            WorkoutItems = new HashSet<WorkoutItems>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ExerciseId { get; set; }
        public string ExerciseName { get; set; }
        public string ExerciseDescription { get; set; }
        public DateTime? AddDate { get; set; }
        public string AddName { get; set; }

        public ICollection<WorkoutItems> WorkoutItems { get; set; }
    }
}
