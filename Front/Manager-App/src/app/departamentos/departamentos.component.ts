import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-departamentos',
  templateUrl: './departamentos.component.html',
  styleUrls: ['./departamentos.component.css']
})
export class DepartamentosComponent implements OnInit {

  public departamentos: any = [];
  public departamentosFiltrados: any = []
  private _filtroLista: string = '';

  public get filtroLista(): string {
    return this._filtroLista
  }

  public set filtroLista(value: string) {
    this._filtroLista = value;
    this.departamentosFiltrados = this.filtroLista ? this.filtrar(this.filtroLista) : this.departamentos;
  }

  filtrar(filtrarPor: string): any {
    filtrarPor = filtrarPor.toLocaleLowerCase();
    return this.departamentos.filter(
      (departamento: {nome: string; sigla: string;}) => departamento.nome.toLocaleLowerCase().indexOf(filtrarPor) !== -1 || departamento.sigla.toLocaleLowerCase().indexOf(filtrarPor) !== -1 || departamento.sigla.toLocaleLowerCase().indexOf(filtrarPor) !== -1
    )
  }

  constructor(private http: HttpClient ) { }

  ngOnInit(): void {
    this.getDepartamentos();
  }

  public getDepartamentos(): void {
    this.http.get('https://localhost:5001/api/Department').subscribe(
      response => {
        this.departamentos = response;
        this.departamentosFiltrados = this.departamentos;
      },
      error => console.log(error)
    );
  }
}
