import { NgFor } from '@angular/common';
import { HttpClient } from '@angular/common/http';
import { Component, inject, OnInit } from '@angular/core';
import { RouterOutlet } from '@angular/router';

@Component({
  selector: 'app-root',
  imports: [RouterOutlet, NgFor],
  standalone : true,
  templateUrl: './app.component.html',
  styleUrl: './app.component.css'
})
export class AppComponent implements OnInit{
  httpClient = inject(HttpClient);
  title = 'DatingApp-net9';
  users : any;

  ngOnInit(): void {
    this.httpClient.get('https://localhost:5001/api/user').subscribe(
      {
        next: response => this.users = response,
        error: error => console.log(error),
        complete: () => console.log('Request had completed')
      }
    )
  }
  
}
