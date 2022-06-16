import { ComponentFixture, TestBed } from '@angular/core/testing';

import { FormpesquisaComponent } from './formpesquisa.component';

describe('FormpesquisaComponent', () => {
  let component: FormpesquisaComponent;
  let fixture: ComponentFixture<FormpesquisaComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ FormpesquisaComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(FormpesquisaComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
