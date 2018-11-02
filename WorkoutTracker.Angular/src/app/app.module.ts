import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { HttpClientModule } from '@angular/common/http';
import { ReactiveFormsModule } from '@angular/forms';

import { AppComponent } from './app.component';
import { ExerciseComponent } from './exercise/exercise.component';
import { WorkoutitemComponent } from './workoutitem/workoutitem.component';
import { NgxsModule, Store } from '@ngxs/store';
import { ExerciseState } from './exercise/state/exercise.state';
import { NgxsReduxDevtoolsPluginModule } from '@ngxs/devtools-plugin';
import { NgxsLoggerPluginModule } from '@ngxs/logger-plugin';

@NgModule({
  declarations: [
    AppComponent,
    ExerciseComponent,
    WorkoutitemComponent
  ],
  imports: [
    BrowserModule,
    HttpClientModule,
    ReactiveFormsModule,
    NgxsModule.forRoot([ExerciseState]),
    NgxsReduxDevtoolsPluginModule.forRoot(),
    NgxsLoggerPluginModule.forRoot()
  ],
  providers: [Store],
  bootstrap: [AppComponent]
})
export class AppModule { }
