import { Injectable } from '@angular/core';
import { Exercise } from './exercise';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { environment } from 'src/environments/environment.prod';

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

    this.http.post(environment.apiPath + '/api/Exercise', this.exercise).subscribe(function (data) {

    });
  }
}
