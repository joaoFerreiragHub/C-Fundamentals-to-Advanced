import { TestBed } from '@angular/core/testing';

import { ServicoLivrosService } from './servico-livros.service';

describe('ServicoLivrosService', () => {
  let service: ServicoLivrosService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(ServicoLivrosService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
