import { TestBed } from '@angular/core/testing';

import { AdminDestaquesService } from './admin-tipos.service';

describe('AdminDestaquesService', () => {
  let service: AdminDestaquesService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(AdminDestaquesService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
