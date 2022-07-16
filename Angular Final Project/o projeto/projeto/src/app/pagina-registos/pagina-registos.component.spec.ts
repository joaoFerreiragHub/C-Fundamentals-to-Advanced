import { ComponentFixture, TestBed } from '@angular/core/testing';

import { PaginaRegistosComponent } from './pagina-registos.component';

describe('PaginaRegistosComponent', () => {
  let component: PaginaRegistosComponent;
  let fixture: ComponentFixture<PaginaRegistosComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ PaginaRegistosComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(PaginaRegistosComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
