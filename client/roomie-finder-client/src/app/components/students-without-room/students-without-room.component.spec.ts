import { ComponentFixture, TestBed } from '@angular/core/testing';

import { StudentsWithoutRoomComponent } from './students-without-room.component';

describe('StudentsWithoutRoomComponent', () => {
  let component: StudentsWithoutRoomComponent;
  let fixture: ComponentFixture<StudentsWithoutRoomComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [StudentsWithoutRoomComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(StudentsWithoutRoomComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
