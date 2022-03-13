import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-departaments',
  templateUrl: './departaments.component.html',
  styleUrls: ['./departaments.component.css']
})
export class DepartamentsComponent implements OnInit {

  public departaments: any;

  constructor(private http: HttpClient ) { }

  ngOnInit(): void {
    this.getDepartaments();
  }

  public getDepartaments(): void {
    this.http.get('https://localhost:5001/api/Department').subscribe(
      response => this.departaments = response,
      error => console.log(error)
    );
  }
}
