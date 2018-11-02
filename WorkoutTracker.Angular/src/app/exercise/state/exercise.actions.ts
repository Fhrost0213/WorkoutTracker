import { Exercise } from '../exercise';

export class AddExercise {
    static readonly type = '[WorkoutTracker] Add Exercise';
    constructor(public payload: Exercise) {}
}

export class LoadExercise {
    static readonly type = '[WorkoutTracker] Load Exercise';
}

export class DeleteExercise {
    static readonly type = '[WorkoutTracker] Delete Exercise';
    constructor(public payload: number) {}
}

