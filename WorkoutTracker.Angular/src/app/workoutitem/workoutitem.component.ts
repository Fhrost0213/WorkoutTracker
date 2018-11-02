import { Component, OnInit } from '@angular/core';
import { FormGroup, FormControl } from '@angular/forms';
import { Observable } from 'rxjs';
import { WorkoutItem } from './workoutitem';
import { Exercise } from '../exercise/exercise';
import { WorkoutitemService } from './workoutitem.service';
import { Select } from '@ngxs/store';
import { ExerciseState } from '../exercise/state/exercise.state';

@Component({
  selector: 'app-workoutitem',
  templateUrl: './workoutitem.component.html',
  styleUrls: ['./workoutitem.component.css']
})
export class WorkoutitemComponent implements OnInit {
  @Select(ExerciseState.getExercises) exercises$: Observable<Exercise[]>;

  addWorkoutItemForm = new FormGroup({
    workoutItemExercise: new FormControl(''),
    workoutItemReps: new FormControl(''),
    workoutItemWeight: new FormControl(''),
    workoutItemDate: new FormControl('')
  });
  workoutItems: Observable<WorkoutItem[]>;

  constructor(private workoutItemService: WorkoutitemService) { }

  ngOnInit() {
  }

  onSubmit(): void {
    if (this.addWorkoutItemForm.valid) {
      const workoutItem: WorkoutItem = {
        Id: 0,
        Exercise: this.addWorkoutItemForm.get('workoutItemExercise').value,
        Reps: this.addWorkoutItemForm.get('workoutItemReps').value,
        Weight: this.addWorkoutItemForm.get('workoutItemWeight').value,
        Date: this.addWorkoutItemForm.get('workoutItemDate').value
      };

      this.workoutItemService.add(workoutItem).subscribe(data => this.setWorkoutItems());
    }
  }

  setWorkoutItems(): void {
    this.workoutItems = this.workoutItemService.get();
  }
}
