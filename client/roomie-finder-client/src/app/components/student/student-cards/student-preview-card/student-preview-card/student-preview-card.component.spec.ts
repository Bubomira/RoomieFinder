import { ComponentFixture, TestBed } from '@angular/core/testing';

import { StudentPreviewCardComponent } from './student-preview-card.component';

describe('StudentPreviewCardComponent', () => {
  let component: StudentPreviewCardComponent;
  let fixture: ComponentFixture<StudentPreviewCardComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [StudentPreviewCardComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(StudentPreviewCardComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
