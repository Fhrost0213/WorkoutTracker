import { Component, OnInit } from '@angular/core';
import { ExerciseService } from './exercise.service';
import { FormControl, FormGroup } from '@angular/forms';
import { Exercise } from './exercise';
import { Observable } from 'rxjs';
import { Store, Select } from '@ngxs/store';
import { AddExercise, DeleteExercise } from './state/exercise.actions';
import { ExerciseState } from './state/exercise.state';

@Component({
  templateUrl: './exercise.component.html',
  styleUrls: ['./exercise.component.css']
})
export class ExerciseComponent implements OnInit {
  addExerciseForm = new FormGroup({
    exerciseName: new FormControl(''),
    exerciseDescription: new FormControl('')
  });

  @Select(ExerciseState.getExercises) exercises$: Observable<Exercise[]>;

  constructor(private store: Store) {}

  ngOnInit() {}

  onSubmit(): void {
    const exercise: Exercise = {
        ExerciseId: 0,
        ExerciseName: this.addExerciseForm.get('exerciseName').value,
        ExerciseDescription: this.addExerciseForm.get('exerciseDescription').value,
        AddDate: new Date(),
        AddName: ''
    };

    this.store.dispatch(new AddExercise(exercise));
  }

  onDeleteExercise(id: number): void {
    this.store.dispatch(new DeleteExercise(id));
  }
}
