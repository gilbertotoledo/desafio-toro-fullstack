import { NgModule } from '@angular/core';
import { CommonModule, DatePipe } from '@angular/common';
import { HttpClientModule, HTTP_INTERCEPTORS } from '@angular/common/http';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { RouterModule } from '@angular/router';

import { P404Component } from './view/error/404.component';
import { P500Component } from './view/error/500.component';
import { LoadingComponent } from './view/loading/loading.component';

@NgModule({
  declarations: [
    P404Component,
    P500Component,
    LoadingComponent
  ],
  exports: [
    LoadingComponent
  ],
  imports: [
    HttpClientModule,
    CommonModule,
    FormsModule,
    RouterModule,
    ReactiveFormsModule,
  ],
  providers: []
})
export class SharedModule { }
