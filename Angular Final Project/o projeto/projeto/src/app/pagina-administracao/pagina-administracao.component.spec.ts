import { ComponentFixture, TestBed } from '@angular/core/testing';

import { PaginaAdministracaoComponent } from './pagina-administracao.component';

describe('PaginaAdministracaoComponent', () => {
  let component: PaginaAdministracaoComponent;
  let fixture: ComponentFixture<PaginaAdministracaoComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ PaginaAdministracaoComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(PaginaAdministracaoComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
