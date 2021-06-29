import { Component, OnInit } from '@angular/core';
import { UserTypeTestService } from '../services/user-type-test.service';

@Component({
  selector: 'lib-user-type-test',
  template: ` <p>user-type-test works!</p> `,
  styles: [],
})
export class UserTypeTestComponent implements OnInit {
  constructor(private service: UserTypeTestService) {}

  ngOnInit(): void {
    this.service.sample().subscribe(console.log);
  }
}
