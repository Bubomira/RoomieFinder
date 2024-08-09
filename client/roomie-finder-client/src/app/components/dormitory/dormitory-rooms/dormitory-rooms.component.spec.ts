import { ComponentFixture, TestBed } from '@angular/core/testing';

import { DormitoryRoomsComponent } from './dormitory-rooms.component';

describe('DormitoryRoomsComponent', () => {
  let component: DormitoryRoomsComponent;
  let fixture: ComponentFixture<DormitoryRoomsComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [DormitoryRoomsComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(DormitoryRoomsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
