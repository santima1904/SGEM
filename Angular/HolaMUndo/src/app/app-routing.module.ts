import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { TablaPersonasComponent } from './components/tabla-personas/tabla-personas.component';

const routes: Routes = [
  {path: 'tabla', component: TablaPersonasComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
