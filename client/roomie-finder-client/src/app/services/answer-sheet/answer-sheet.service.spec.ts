import { TestBed } from '@angular/core/testing';

import { AnswerSheetService } from './answer-sheet.service';

describe('AnswerSheetService', () => {
  let service: AnswerSheetService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(AnswerSheetService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
