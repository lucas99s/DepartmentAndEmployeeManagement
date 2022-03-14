import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-funcionarios',
  templateUrl: './funcionarios.component.html',
  styleUrls: ['./funcionarios.component.css']
})
export class FuncionariosComponent implements OnInit {

  public funcionarios: any = [];

  constructor(private http: HttpClient ) { }

  ngOnInit(): void {
    this.getFuncionarios();
  }

  public getFuncionarios(): void {
    this.http.get('https://localhost:5001/api/Employee').subscribe(
      response => this.funcionarios = response,
      error => console.log(error)
    );
  }

}
