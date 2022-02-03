import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-formulario-personas',
  templateUrl: './formulario-personas.component.html',
  styleUrls: ['./formulario-personas.component.css']
})
export class FormularioPersonasComponent implements OnInit {

  constructor(private router:Router) { }

  ngOnInit(): void {
    
  }

  saludar(){
    alert("Hola "+(<HTMLInputElement>(document.getElementById("nombre"))).value+(<HTMLInputElement>(document.getElementById("apellidos"))).value);
  }

  goback(){
    this.router.navigateByUrl('tabla')
  }

}
