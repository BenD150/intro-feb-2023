import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AboutComponent } from './components/about/about.component';
import { CounterComponent } from './components/counter/counter.component';
import { DashboardComponent } from './components/dashboard/dashboard.component';
import { ShoppingListComponent } from './components/shopping-list/shopping-list.component';

const routes: Routes = [
  {
    path: 'dashboard',
    component: DashboardComponent
  },
  {
    path: 'shopping',
    component: ShoppingListComponent
  },
  {
    path: 'about',
    component: AboutComponent
  },
  {
    path: 'counter',
    component: CounterComponent
  },
  {
    path: '**', // <-- Angular syntax that matches ANYTHING
    redirectTo: 'dashboard'
  }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
