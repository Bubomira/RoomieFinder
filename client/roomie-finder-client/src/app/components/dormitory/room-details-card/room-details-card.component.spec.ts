import { ComponentFixture, TestBed } from '@angular/core/testing';

import { RoomDetailsCardComponent } from './room-details-card.component';

describe('RoomDetailsCardComponent', () => {
  let component: RoomDetailsCardComponent;
  let fixture: ComponentFixture<RoomDetailsCardComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [RoomDetailsCardComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(RoomDetailsCardComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
