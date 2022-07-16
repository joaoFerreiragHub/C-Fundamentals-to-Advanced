import { TestBed } from '@angular/core/testing';

import { ServutilizadoresService } from './servutilizadores.service';

describe('ServutilizadoresService', () => {
  let service: ServutilizadoresService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(ServutilizadoresService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
