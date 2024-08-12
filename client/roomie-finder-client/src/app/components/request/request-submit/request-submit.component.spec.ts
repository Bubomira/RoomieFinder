import { ComponentFixture, TestBed } from '@angular/core/testing';

import { RequestSubmitComponent } from './request-submit.component';

describe('RequestSubmitComponent', () => {
  let component: RequestSubmitComponent;
  let fixture: ComponentFixture<RequestSubmitComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [RequestSubmitComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(RequestSubmitComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
