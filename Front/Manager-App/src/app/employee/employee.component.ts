import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-employee',
  templateUrl: './employee.component.html',
  styleUrls: ['./employee.component.css']
})
export class EmployeeComponent implements OnInit {

  public employees: any = [];

  constructor(private http: HttpClient ) { }

  ngOnInit(): void {
    this.getEmployees();
  }

  public getEmployees(): void {
    this.http.get('https://localhost:5001/api/Employee').subscribe(
      response => this.employees = response,
      error => console.log(error)
    );
  }

}
