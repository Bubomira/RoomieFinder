import { ComponentFixture, TestBed } from '@angular/core/testing';

import { RoomateCardComponent } from './roomate-card.component';

describe('RoomateCardComponent', () => {
  let component: RoomateCardComponent;
  let fixture: ComponentFixture<RoomateCardComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [RoomateCardComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(RoomateCardComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
