import { Component } from '@angular/core';
import {HttpClient} from '@angular/common/http';
@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  constructor(private http:HttpClient){}
getmovies() {
this.http.get('https://localhost:7110/getmovies').subscribe((data)=>console.log("movies got"));
}
  title = 'BMSFE';
}
