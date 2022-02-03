import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-listado-personas',
  templateUrl: './listado-personas.component.html',
  styleUrls: ['./listado-personas.component.css']
})
export class ListadoPersonasComponent implements OnInit {

  constructor(private router:Router) { }

  ngOnInit(): void {
  }

  goback(){
    this.router.navigateByUrl('tabla')
  }
}
