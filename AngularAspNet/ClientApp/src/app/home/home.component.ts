import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { IProduct } from '../Interface/IProduct';
@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
})
export class HomeComponent implements OnInit{
  constructor(private http:HttpClient){

  }
  produckts?: IProduct[]
  ngOnInit(): void{
    this.http.get<IProduct[]>('weatherforecasts').subscribe(result => {
      this.produckts = result;
      console.log(result)
    }, error => console.error(error));
  }

}
