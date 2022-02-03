import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';

@Component({
  selector: 'app-formulario-reactivo',
  templateUrl: './formulario-reactivo.component.html',
  styleUrls: ['./formulario-reactivo.component.css']
})
export class FormularioReactivoComponent implements OnInit {

  formulario:FormGroup;

  constructor(private router:Router) { }

  ngOnInit(): void {
    this.formulario = new FormGroup({
      nombre: new FormControl('',[Validators.required]),
      apellidos: new FormControl('',[Validators.maxLength(20)])
    });
  }

  saludo(){
  
      alert('Hola '+ this.formulario.controls.nombre.value + ' ' + this.formulario.controls.apellidos.value);

  }

  goback(){
    this.router.navigateByUrl('tabla')
  }
}
