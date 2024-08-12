import { ComponentFixture, TestBed } from '@angular/core/testing';

import { RequestProfileCardComponent } from './request-profile-card.component';

describe('RequestProfileCardComponent', () => {
  let component: RequestProfileCardComponent;
  let fixture: ComponentFixture<RequestProfileCardComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [RequestProfileCardComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(RequestProfileCardComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
