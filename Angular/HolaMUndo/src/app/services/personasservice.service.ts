import { Injectable } from '@angular/core';

import { HttpClient } from '@angular/common/http';

import { Observable } from 'rxjs';

import { Persona } from '../interfaces/persona';

@Injectable({
  providedIn: 'root'
})
export class PersonasserviceService {

  urlWebApi = 'https://crudpersonasaspsantimartinez.azurewebsites.net/api/Personas';

  constructor(private http:HttpClient) { }

  listadoPersonas(): Observable<Persona[]>{

    return this.http.get<Persona[]>(this.urlWebApi);
    
    }
}
