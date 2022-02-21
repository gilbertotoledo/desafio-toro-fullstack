import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';
import { RouterModule } from '@angular/router';

import { LoginComponent } from './login/login.component';
import { UserService } from './service/user.service';
import { AccountRoutingModule } from './account-routing.module';

@NgModule({
  declarations: [LoginComponent],
  exports: [],
  imports: [
    AccountRoutingModule,
    RouterModule,
    CommonModule,
    FormsModule,
    RouterModule,
  ],
  providers: [UserService],
})
export class AccountModule {}
