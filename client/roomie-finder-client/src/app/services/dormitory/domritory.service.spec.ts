import { TestBed } from '@angular/core/testing';

import { DomritoryService } from './domritory.service';

describe('DomritoryService', () => {
  let service: DomritoryService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(DomritoryService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
