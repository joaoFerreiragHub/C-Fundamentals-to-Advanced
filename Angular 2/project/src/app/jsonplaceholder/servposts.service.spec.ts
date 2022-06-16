import { TestBed } from '@angular/core/testing';

import { ServpostsService } from './servposts.service';

describe('ServpostsService', () => {
  let service: ServpostsService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(ServpostsService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
