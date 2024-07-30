import { TestBed } from '@angular/core/testing';
import { CanActivateFn } from '@angular/router';

import { answerSheetGuard } from './answer-sheet.guard';

describe('answerSheetGuard', () => {
  const executeGuard: CanActivateFn = (...guardParameters) => 
      TestBed.runInInjectionContext(() => answerSheetGuard(...guardParameters));

  beforeEach(() => {
    TestBed.configureTestingModule({});
  });

  it('should be created', () => {
    expect(executeGuard).toBeTruthy();
  });
});
