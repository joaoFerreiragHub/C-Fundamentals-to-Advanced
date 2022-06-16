import { ComponentFixture, TestBed } from '@angular/core/testing';

import { GestaolivrosComponent } from './gestaolivros.component';

describe('GestaolivrosComponent', () => {
  let component: GestaolivrosComponent;
  let fixture: ComponentFixture<GestaolivrosComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ GestaolivrosComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(GestaolivrosComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
