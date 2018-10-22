import { Component, OnInit } from '@angular/core';
import { ExerciseService } from './exercise.service';
import { FormControl, FormGroup } from '@angular/forms';

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

  constructor(private exerciseService: ExerciseService) { }

  ngOnInit() {
  }

  onSubmit(): void {
    if (this.addExerciseForm.valid) {
      const exerciseName = this.addExerciseForm.get('exerciseName').value;
      const exerciseDescription = this.addExerciseForm.get('exerciseDescription').value;

      this.exerciseService.addExercise(
        exerciseName,
        exerciseDescription);
    }
  }

}
