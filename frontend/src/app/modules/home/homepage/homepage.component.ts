import { UserService } from './../../account/service/user.service';
import { User } from './../../account/model/user.model';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-homepage',
  templateUrl: './homepage.component.html',
  styleUrls: ['./homepage.component.scss']
})
export class HomepageComponent implements OnInit {
  user: User = null;

  constructor(private userService: UserService) { }

  async ngOnInit(): Promise<void> {
    this.user = await this.userService.getMyData();
  }

}
