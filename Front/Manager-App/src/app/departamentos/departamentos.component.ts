import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-departaments',
  templateUrl: './departaments.component.html',
  styleUrls: ['./departaments.component.css']
})
export class DepartamentsComponent implements OnInit {

  public departaments: any = [];
  public departamentosFiltrados: any = []
  private _filtroLista: string = '';

  public get filtroLista(): string {
    return this._filtroLista
  }

  public set filtroLista(value: string) {
    this._filtroLista = value;
    this.departamentosFiltrados = this.filtroLista ? this.filtrar(this.filtroLista) : this.departaments;
  }

  filtrar(filtrarPor: string): any {
    filtrarPor = filtrarPor.toLocaleLowerCase();
    return this.departaments.filter(
      (departament: {nome: string; sigla: string;}) => departament.nome.toLocaleLowerCase().indexOf(filtrarPor) !== -1 || departament.sigla.toLocaleLowerCase().indexOf(filtrarPor) !== -1 || departament.sigla.toLocaleLowerCase().indexOf(filtrarPor) !== -1
    )
  }

  constructor(private http: HttpClient ) { }

  ngOnInit(): void {
    this.getDepartaments();
  }

  public getDepartaments(): void {
    this.http.get('https://localhost:5001/api/Department').subscribe(
      response => {
        this.departaments = response;
        this.departamentosFiltrados = this.departaments;
      },
      error => console.log(error)
    );
  }
}
