import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

import { P404Component } from './modules/shared/view/error/404.component';
import { P500Component } from './modules/shared/view/error/500.component';

export const routes: Routes = [
  { path: '', redirectTo: 'account/login', pathMatch: 'full'},
  { path: '404', component: P404Component, data: { title: 'Page 404'} },
  { path: '500', component: P500Component, data: { title: 'Page 500'} },
  { path: '', data: { title: 'Home' },
    children: [
      { path: 'account', loadChildren: () => import('./modules/account/account.module').then(m => m.AccountModule)},
      { path: 'home', loadChildren: () => import('./modules/home/home.module').then(m => m.HomeModule)}
    ]
  },
  { path: '**', component: P404Component }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
