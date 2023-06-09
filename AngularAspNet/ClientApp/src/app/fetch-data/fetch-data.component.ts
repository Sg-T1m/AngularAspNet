import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-fetch-data',
  templateUrl: './fetch-data.component.html'
})
export class FetchDataComponent {
  public forecasts: any[]= [];

  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    http.get<any>('weatherforecasts/all/2').subscribe(result => {
     
      this.forecasts = result;
      console.log(this.forecasts)
    }, error => console.error(error));
  }
}

interface WeatherForecast {
  date: string;
  temperatureC: number;
  temperatureF: number;
  summary: string;
  components: any[];
}
