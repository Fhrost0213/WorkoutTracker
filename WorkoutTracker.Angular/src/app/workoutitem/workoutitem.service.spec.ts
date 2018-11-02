import { TestBed, inject } from '@angular/core/testing';

import { WorkoutitemService } from './workoutitem.service';

describe('WorkoutitemService', () => {
  beforeEach(() => {
    TestBed.configureTestingModule({
      providers: [WorkoutitemService]
    });
  });

  it('should be created', inject([WorkoutitemService], (service: WorkoutitemService) => {
    expect(service).toBeTruthy();
  }));
});
