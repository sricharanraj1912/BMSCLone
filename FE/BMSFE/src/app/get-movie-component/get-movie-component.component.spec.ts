import { ComponentFixture, TestBed } from '@angular/core/testing';

import { GetMovieComponentComponent } from './get-movie-component.component';

describe('GetMovieComponentComponent', () => {
  let component: GetMovieComponentComponent;
  let fixture: ComponentFixture<GetMovieComponentComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [GetMovieComponentComponent]
    });
    fixture = TestBed.createComponent(GetMovieComponentComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
