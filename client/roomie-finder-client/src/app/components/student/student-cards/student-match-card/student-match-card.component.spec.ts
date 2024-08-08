import { ComponentFixture, TestBed } from '@angular/core/testing';

import { StudentMatchCardComponent } from './student-match-card.component';

describe('StudentMatchCardComponent', () => {
  let component: StudentMatchCardComponent;
  let fixture: ComponentFixture<StudentMatchCardComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [StudentMatchCardComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(StudentMatchCardComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
