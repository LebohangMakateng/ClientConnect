import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { HomeComponent } from './home/home.component';
import { ListsComponent } from './lists/lists.component';
import { AuthGuard } from './_guards/auth.guard';
import { FreelancerDetailComponent } from './Freelancers/freelancer-detail/freelancer-detail.component';
import { FreelancerlistComponent } from './Freelancers/freelancerlist/freelancerlist.component';

const routes: Routes = [
  {path: '', component: HomeComponent},
  {
    path: '',
    runGuardsAndResolvers: 'always',
    canActivate: [AuthGuard],
    children: [
      {path: 'freelancers', component: FreelancerlistComponent, canActivate: [AuthGuard]},
      {path: 'freelancers/:id', component: FreelancerDetailComponent},
      {path: 'lists', component: ListsComponent},
    ]
  },
  {path: '**', component: HomeComponent, pathMatch: 'full'},
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
