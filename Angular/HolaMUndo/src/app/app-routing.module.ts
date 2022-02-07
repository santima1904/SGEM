import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { FormularioPersonasComponent } from './components/formulario-personas/formulario-personas.component';
import { FormularioReactivoComponent } from './components/formulario-reactivo/formulario-reactivo.component';
import { ListadoPersonasComponent } from './components/listado-personas/listado-personas.component';
import { TablaPersonasComponent } from './components/tabla-personas/tabla-personas.component';

const routes: Routes = [
  {path: 'tabla', component: TablaPersonasComponent},
  {path:'formulario',component: FormularioPersonasComponent},
  {path:'listado',component: ListadoPersonasComponent},
  {path:'reactivo',component: FormularioReactivoComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
