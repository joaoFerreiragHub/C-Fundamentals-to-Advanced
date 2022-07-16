import { TestBed } from '@angular/core/testing';

import { PartilharService } from './partilhar.service';

describe('PartilharService', () => {
  let service: PartilharService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(PartilharService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
