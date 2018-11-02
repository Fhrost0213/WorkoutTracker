import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { WorkoutitemComponent } from './workoutitem.component';

describe('WorkoutitemComponent', () => {
  let component: WorkoutitemComponent;
  let fixture: ComponentFixture<WorkoutitemComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ WorkoutitemComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(WorkoutitemComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
