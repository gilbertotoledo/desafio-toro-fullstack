import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';

import { AccountModule } from './../account/account.module';
import { SharedModule } from '@shared/shared.module';
import { HomeRoutingModule } from './home-routing.module';
import { HomepageComponent } from './homepage/homepage.component';
import { CheckingAccountComponent } from './checking-account/checking-account.component';
import { NavigationComponent } from './navigation/navigation.component';

@NgModule({
  declarations: [
   HomepageComponent,
   CheckingAccountComponent,
   NavigationComponent
  ],
  exports: [],
  imports: [
    HomeRoutingModule,
    SharedModule,
    AccountModule,
    CommonModule,
    FormsModule,
    ReactiveFormsModule,
  ],
  providers: []
})
export class HomeModule { }
