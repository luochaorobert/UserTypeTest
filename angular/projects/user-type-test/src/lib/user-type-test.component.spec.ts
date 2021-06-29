import { ComponentFixture, TestBed, waitForAsync } from '@angular/core/testing';

import { UserTypeTestComponent } from './user-type-test.component';

describe('UserTypeTestComponent', () => {
  let component: UserTypeTestComponent;
  let fixture: ComponentFixture<UserTypeTestComponent>;

  beforeEach(waitForAsync(() => {
    TestBed.configureTestingModule({
      declarations: [ UserTypeTestComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(UserTypeTestComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
