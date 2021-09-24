import { Component, Inject } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { error } from 'selenium-webdriver';

@Component({
  selector: 'app-fetch-data',
  templateUrl: './fetch-data.component.html'
})
export class FetchDataComponent {
  public forecasts: WeatherForecast[];
  messageLabel: string;
  firstName: string;
  lastName: string;
  address1: string;
  address2: string;
  employeeID: number;

  // https://localhost:44396/swagger/index.html
  // Base URL: http://localhost:4200/weatherforeacst
  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    //http.get<WeatherForecast[]>(baseUrl + 'weatherforecast').subscribe(result => {
    //  this.forecasts = result;
    //}, error => console.error(error));    

    const httpOptions = {
      headers: new HttpHeaders({
        'Content-Type': 'application/json',
        'Access-Control-Allow-Origin': '*',
        'Access-Control-Allow-Methods': 'OPTIONS, GET, POST',
        'Access-Control-Allow-Credentials': 'true',
      })
    };

    //this.clientSvc.getEmployee(emp).subscribe(result => { .. });

    http.get('https://localhost:44396/api/home', httpOptions).subscribe(result => {
      console.log(`Ze-Clowns-API Call Results: `, result);

      this.messageLabel = result['Message'];

      this.firstName = result['firstname'];
      this.lastName = result['lastname'];
      this.address1 = result['address1'];
      this.address2 = result['address2']
      this.employeeID = result['employeeID'];
    },
      error => {
        console.log(error);
      });
  }
}

interface WeatherForecast {
  date: string;
  temperatureC: number;
  temperatureF: number;
  summary: string;
}
