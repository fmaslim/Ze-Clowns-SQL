import { Component } from '@angular/core';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent {
  employeeName: string = 'John Doe';

  streetName: string = 'Jl. Singosari 9C';

  boolTrue: boolean = true;
  boolFalse: boolean = false;

  getResult() {
    return true;
  }
}
