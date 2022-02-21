import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';

import { UserService } from './../service/user.service';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.scss'],
})
export class LoginComponent implements OnInit {
  public username: string = '';
  public password: string = '';
  public isLoginFail: boolean = false;

  constructor(private router: Router, private userService: UserService) {}

  ngOnInit(): void {}

  onClickLogin() {
    this.isLoginFail = false;

    this.userService.doLogin(this.username, this.password)
      .then(user => {
          localStorage.setItem("userId", user.id);
          this.router.navigate(['/home']);
      })
      .catch( error => {
        this.isLoginFail = true;
      });

  }
}
