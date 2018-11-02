import { Injectable } from '@angular/core';
import { Exercise } from './exercise';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { environment } from 'src/environments/environment.prod';
import { map } from 'rxjs/operators';
import { Observable, BehaviorSubject } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class ExerciseService {

  constructor(private http: HttpClient) { }

  addExercise(exercise: Exercise): Observable<object> {
    return this.http.post(environment.apiPath + '/api/Exercise', exercise);
  }

  getExercises(): Observable<Exercise[]> {
    return this.http.get<Exercise[]>(environment.apiPath + '/api/Exercise');
  }

  deleteExercise(exerciseId: number): Observable<object> {
    return this.http.delete(environment.apiPath + '/api/Exercise/' + exerciseId);
  }
}
