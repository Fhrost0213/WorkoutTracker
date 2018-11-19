using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace WorkoutTracker.Core.Models
{
    public partial class WorkoutItems
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int WorkoutItemId { get; set; }
        public int? ExerciseId { get; set; }
        public int? Reps { get; set; }
        public decimal? Weight { get; set; }
        public DateTime? WorkoutItemDate { get; set; }
        public DateTime? AddDate { get; set; }
        public string AddName { get; set; }
        [ForeignKey("ExerciseId")]
        public Exercises Exercise { get; set; }
    }
}
