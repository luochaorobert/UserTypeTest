import { TestBed } from '@angular/core/testing';

import { UserTypeTestService } from './user-type-test.service';

describe('UserTypeTestService', () => {
  let service: UserTypeTestService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(UserTypeTestService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
