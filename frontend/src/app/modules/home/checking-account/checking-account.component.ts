import { Component, OnInit } from '@angular/core';
import { User } from '@modules/account/model/user.model';
import { UserService } from '@modules/account/service/user.service';

@Component({
  selector: 'app-checking-account',
  templateUrl: './checking-account.component.html',
  styleUrls: ['./checking-account.component.scss']
})
export class CheckingAccountComponent implements OnInit {
  user: User = null;

  constructor(private userService: UserService) { }

  async ngOnInit(): Promise<void> {
    this.user = await this.userService.getMyData();
  }

}
