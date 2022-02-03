import { Component, OnInit } from '@angular/core';
import { Routes, RouterModule, Router } from '@angular/router';

@Component({
  selector: 'app-tabla-personas',
  templateUrl: './tabla-personas.component.html',
  styleUrls: ['./tabla-personas.component.css']
})
export class TablaPersonasComponent implements OnInit {
  [x: string]: any;

  constructor(private router:Router) { }

  ngOnInit(): void {
  }

  listado(){
    this.router.navigateByUrl('listado')
  }

}
