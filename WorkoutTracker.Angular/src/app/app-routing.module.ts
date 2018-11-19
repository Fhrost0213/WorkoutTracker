import { NgModule } from '@angular/core';
import { RouterModule } from '@angular/router';
import { ExerciseComponent } from './exercise/exercise.component';
import { HomeComponent } from './home/home.component';
import { WorkoutitemComponent } from './workoutitem/workoutitem.component';

@NgModule({
  imports: [
    RouterModule.forRoot([
      { path: 'home', component: HomeComponent },
      { path: 'workout', component: WorkoutitemComponent },
      { path: 'exercises', component: ExerciseComponent },
      { path: '', redirectTo: 'home', pathMatch: 'full' },
      { path: '**', redirectTo: 'home', pathMatch: 'full' }
    ])
  ],
  exports: [
    RouterModule
  ]
})
export class AppRoutingModule { }
