import { Injectable } from '@angular/core';
import { Exercise } from './exercise';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { environment } from 'src/environments/environment.prod';
import { map } from 'rxjs/operators';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class ExerciseService {
  exercise: Exercise;

  constructor(private http: HttpClient) { }

  addExercise(exerciseName: string, exerciseDescription: string): Observable<object> {
    this.exercise = {
      Id: 0,
      Name: exerciseName,
      Description: exerciseDescription
    };

    return this.http.post(environment.apiPath + '/api/Exercise', this.exercise);
  }

  getExercises(): Observable<Exercise[]> {
    return this.http.get<Exercise[]>(environment.apiPath + '/api/Exercise');
  }

  deleteExercise(exerciseId: number): Observable<object> {
    return this.http.delete(environment.apiPath + '/api/Exercise/' + exerciseId);
  }
}
