import { ComponentFixture, TestBed } from '@angular/core/testing';

import { StudentRoomateMatchesComponent } from './student-roomate-matches.component';

describe('StudentRoomateMatchesComponent', () => {
  let component: StudentRoomateMatchesComponent;
  let fixture: ComponentFixture<StudentRoomateMatchesComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [StudentRoomateMatchesComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(StudentRoomateMatchesComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
