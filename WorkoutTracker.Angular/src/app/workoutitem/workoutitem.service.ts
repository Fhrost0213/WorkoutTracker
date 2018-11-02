import { Injectable } from '@angular/core';
import { WorkoutItem } from './workoutitem';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class WorkoutitemService {

  constructor(private http: HttpClient) { }

  add(workoutItem: WorkoutItem): Observable<object> {
    return this.http.post(environment.apiPath + '/api/WorkoutItem', workoutItem);
  }

  get(): Observable<WorkoutItem[]> {
    return this.http.get<WorkoutItem[]>(environment.apiPath + '/api/WorkoutItem');
  }
}
