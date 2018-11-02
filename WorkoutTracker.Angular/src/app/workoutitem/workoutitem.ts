import { Exercise } from '../exercise/exercise';

export interface WorkoutItem {
    Id: number;
    Exercise: Exercise;
    Reps: number;
    Weight: number;
    Date: Date;
}
