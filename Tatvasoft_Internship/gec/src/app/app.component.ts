import { Component } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { HeaderComponent } from './header/header.component';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [HeaderComponent,RouterOutlet,CommonModule,FormsModule],
  templateUrl: './app.component.html',
  styleUrl: './app.component.css'
})
// export class AppComponent {
//   title = 'gec';
//   name = 'Gec Bvn';
//   visibility = true;
//   list = [12,23,34,45,56];

// store = " "
//  listner(){
//    this.visibility = !this.visibility;
//    console.log(this.store)
//  }
// }

export class AppComponent {
  title = 'Login';
  username = '';
  pass = '';

  loginCheck() {
    if (this.username === 'Hetvi' && this.pass === '123') {
      console.log("Login Successful");
    } else {
      console.log("Login Failed");}
  }
}