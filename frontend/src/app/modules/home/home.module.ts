import { SharedModule } from './../shared/shared.module';
import { HomeRoutingModule } from './home-routing.module';
import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { HttpClientModule } from '@angular/common/http';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { RouterModule } from '@angular/router';

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
    HttpClientModule,
    CommonModule,
    FormsModule,
    RouterModule,
    ReactiveFormsModule,
    SharedModule
  ],
  providers: []
})
export class HomeModule { }
