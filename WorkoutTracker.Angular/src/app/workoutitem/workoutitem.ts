import { Exercise } from '../exercise/exercise';

export interface WorkoutItem {
    WorkoutItemId: number;
    Exercise: Exercise;
    ExerciseId: number;
    Reps: number;
    Weight: number;
    WorkoutItemDate: Date;
    AddDate: Date;
    AddName: string;
}
