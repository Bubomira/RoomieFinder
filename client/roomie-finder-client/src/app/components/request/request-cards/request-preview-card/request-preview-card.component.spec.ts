import { ComponentFixture, TestBed } from '@angular/core/testing';

import { RequestPreviewCardComponent } from './request-preview-card.component';

describe('RequestPreviewCardComponent', () => {
  let component: RequestPreviewCardComponent;
  let fixture: ComponentFixture<RequestPreviewCardComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [RequestPreviewCardComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(RequestPreviewCardComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
