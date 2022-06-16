import { ComponentFixture, TestBed } from '@angular/core/testing';

import { InfolivroComponent } from './infolivro.component';

describe('InfolivroComponent', () => {
  let component: InfolivroComponent;
  let fixture: ComponentFixture<InfolivroComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ InfolivroComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(InfolivroComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
