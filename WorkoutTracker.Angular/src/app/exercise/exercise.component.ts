import { Component, OnInit } from '@angular/core';
import { ExerciseService } from './exercise.service';
import { FormControl, FormGroup } from '@angular/forms';
import { Exercise } from './exercise';
import { Observable } from 'rxjs';

@Component({
  selector: 'app-exercise',
  templateUrl: './exercise.component.html',
  styleUrls: ['./exercise.component.css']
})
export class ExerciseComponent implements OnInit {
  addExerciseForm = new FormGroup({
    exerciseName: new FormControl(''),
    exerciseDescription: new FormControl('')
  });
  exercises: Observable<Exercise[]>;

  constructor(private exerciseService: ExerciseService) { }

  ngOnInit() {
    this.setExercises();
  }

  onSubmit(): void {
    if (this.addExerciseForm.valid) {
      const exerciseName = this.addExerciseForm.get('exerciseName').value;
      const exerciseDescription = this.addExerciseForm.get('exerciseDescription').value;

      this.exerciseService.addExercise(
        exerciseName,
        exerciseDescription).subscribe(data => this.setExercises());
    }
  }

  setExercises(): void {
    this.exercises = this.exerciseService.getExercises();
  }

  onDeleteExercise(id: number): void {
    this.exerciseService.deleteExercise(id).subscribe(data => this.setExercises());
  }
}
