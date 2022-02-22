import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';

import { LoginComponent } from './login/login.component';
import { AccountRoutingModule } from './account-routing.module';
import { SharedModule } from '@modules/shared/shared.module';

@NgModule({
  declarations: [LoginComponent],
  exports: [],
  imports: [
    SharedModule,
    AccountRoutingModule,
    CommonModule,
    FormsModule,
  ],
  providers: [],
})
export class AccountModule {}
