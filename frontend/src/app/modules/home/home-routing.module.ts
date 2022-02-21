import { HomepageComponent } from './homepage/homepage.component';
import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { CheckingAccountComponent } from './checking-account/checking-account.component';

const routes: Routes = [
  {
    path: '',
    data: {
      title: 'Home'
    },
    children: [
      {
        path: '',
        component: HomepageComponent,
        data: {
          title: 'Home'
        }
      },
      {
        path: 'checking-account',
        component: CheckingAccountComponent,
        data: {
          title: 'CheckingAccount'
        }
      }
    ]
  }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class HomeRoutingModule {}
