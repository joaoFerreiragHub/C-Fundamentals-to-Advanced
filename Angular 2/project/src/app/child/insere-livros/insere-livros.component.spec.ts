import { ComponentFixture, TestBed } from '@angular/core/testing';

import { InsereLivrosComponent } from './insere-livros.component';

describe('InsereLivrosComponent', () => {
  let component: InsereLivrosComponent;
  let fixture: ComponentFixture<InsereLivrosComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ InsereLivrosComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(InsereLivrosComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
