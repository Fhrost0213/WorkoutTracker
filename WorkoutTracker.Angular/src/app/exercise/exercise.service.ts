import { Injectable } from '@angular/core';
import { Exercise } from './exercise';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class ExerciseService {
  exercise: Exercise;

  constructor(private http: HttpClient) { }

  addExercise(exerciseName: string, exerciseDescription: string) {
    this.exercise = {
      Id: 0,
      Name: exerciseName,
      Description: exerciseDescription
    };

    const body = JSON.stringify(this.exercise);

    this.http.post('/api/exercise', body);
  }
}
