import { State, StateContext, Action, NgxsOnInit, Selector } from '@ngxs/store';
import { Exercise } from '../exercise';
import { ExerciseService } from '../exercise.service';
import { AddExercise, LoadExercise, DeleteExercise } from './exercise.actions';

export interface ExerciseStateModel {
    Exercises: Exercise[];
}​

@State<ExerciseStateModel>({
  name: 'exercises',
  defaults: {
      Exercises: []
  }
})
export class ExerciseState implements NgxsOnInit {

    @Selector()
    static getExercises(state: ExerciseStateModel) {
        return state.Exercises;
    }

    constructor(private exerciseService: ExerciseService) {
    }

    ngxsOnInit({dispatch}: StateContext<any>) {
        dispatch(new LoadExercise());
    }

    @Action(AddExercise)
    addExercise({dispatch}: StateContext<ExerciseStateModel>, {payload}: AddExercise) {
        this.exerciseService.addExercise(payload).subscribe(
            () => {
                dispatch(new LoadExercise());
            }
        );
    }

    @Action(LoadExercise)
    loadExercises({patchState}: StateContext<ExerciseStateModel>) {
        this.exerciseService.getExercises().subscribe(items => {
            patchState({Exercises: items});
        });
    }

    @Action(DeleteExercise)
    deleteExercise({dispatch}: StateContext<ExerciseStateModel>, {payload}: DeleteExercise) {
        this.exerciseService.deleteExercise(payload).subscribe(
            () => {
                dispatch(new LoadExercise());
            }
        );
    }
}

