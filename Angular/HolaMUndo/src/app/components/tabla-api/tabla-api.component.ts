import { Component, OnInit } from '@angular/core';
import { Persona } from 'src/app/interfaces/persona';
import { PersonasserviceService } from 'src/app/services/personasservice.service';

@Component({
  selector: 'app-tabla-api',
  templateUrl: './tabla-api.component.html',
  styleUrls: ['./tabla-api.component.css']
})
export class TablaApiComponent implements OnInit {
  listadoPersonas:Persona[];

  constructor(private personaService: PersonasserviceService ) { }

  ngOnInit(): void {
    this.personaService.listadoPersonas().subscribe(data=>{
      this.listadoPersonas = data;
    },error=>{

    });
  }

}
