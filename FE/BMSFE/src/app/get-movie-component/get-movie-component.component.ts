import { Component } from '@angular/core';
import {HttpClient} from '@angular/common/http';

@Component({
  selector: 'app-get-movie-component',
  templateUrl: './get-movie-component.component.html',
  styleUrls: ['./get-movie-component.component.css']
})
export class GetMovieComponentComponent {
  
  constructor(private http:HttpClient){}
getmovies() {
this.http.get('https://localhost:7110/getmovies').subscribe((data)=>console.log(data));

}
}