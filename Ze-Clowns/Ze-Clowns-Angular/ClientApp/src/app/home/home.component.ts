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

  firstName: string = 'Nama Pertama: ';
  lastName: string = 'Nama Keluarga: ';
  sex: string = 'Jenis Kelamin';
  activeEmployee: string = 'Karyawan Aktif';

  clickMeButton: string = 'Silahkan Tekan';

  getResult() {
    return true;
  }

  doSomething() {
    //return alert('This is a really long text.\nThis is a really long text.\nThis is a really long text.\nThis is a really long text.\nThis is a really long text.\nThis is a really long text.\nThis is a really long text.\n');
    this.lastName = 'Last Name: ';
  }

  doSomething2() {
    this.firstName = 'First Name: ';
  }

  updateLabels(event: any) {
    //alert('Update Labels called');
    this.firstName = 'First Name: ';
    this.lastName = 'Last Name: ';
  }

  revertLabels(event: any) {
    alert('Revert Labels called');
    this.firstName = 'Nama Pertama: ';
    this.lastName = 'Nama Keluarga: ';
    
  }
}
