import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { TablaPersonasComponent } from './components/tabla-personas/tabla-personas.component';
import { FormularioPersonasComponent } from './components/formulario-personas/formulario-personas.component';
import { ListadoPersonasComponent } from './components/listado-personas/listado-personas.component';
import { ReactiveFormsModule } from '@angular/forms';
import { FormularioReactivoComponent } from './components/formulario-reactivo/formulario-reactivo.component';
import { ProgressSpinnerComponent } from './components/progress-spinner/progress-spinner.component';
import {MatProgressSpinnerModule} from '@angular/material/progress-spinner';
import { RadioButtonComponent } from './components/radio-button/radio-button.component';
import {MatRadioModule} from '@angular/material/radio';
import { SliderComponent } from './components/slider/slider.component';
import {MatSliderModule} from '@angular/material/slider';
import {MatBadgeModule} from '@angular/material/badge';
import { BadgeComponent } from './components/badge/badge.component';
import { HttpClientModule } from '@angular/common/http';
import { TablaApiComponent } from './components/tabla-api/tabla-api.component';

@NgModule({
  declarations: [
    AppComponent,
    TablaPersonasComponent,
    FormularioPersonasComponent,
    ListadoPersonasComponent,
    FormularioReactivoComponent,
    ProgressSpinnerComponent,
    RadioButtonComponent,
    SliderComponent,
    BadgeComponent,
    TablaApiComponent,
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    ReactiveFormsModule,
    MatProgressSpinnerModule,
    MatRadioModule,
    MatSliderModule,
    MatBadgeModule,
    HttpClientModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
