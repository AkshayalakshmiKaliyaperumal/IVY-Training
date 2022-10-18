import { ComponentFixture, TestBed } from '@angular/core/testing';

import { Name1Component } from './name1.component';

describe('Name1Component', () => {
  let component: Name1Component;
  let fixture: ComponentFixture<Name1Component>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ Name1Component ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(Name1Component);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
