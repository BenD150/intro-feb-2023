import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { LearningResourcesComponent } from './learning-resources.component';
import { RouterModule, Routes } from '@angular/router';


const routes: Routes = [
  {
    path: '',
    component: LearningResourcesComponent
  }
]

@NgModule({
  declarations: [
    LearningResourcesComponent
  ],
  imports: [
    CommonModule,
    RouterModule.forChild(routes)
  ]
})
export class LearningResourcesModule { }
