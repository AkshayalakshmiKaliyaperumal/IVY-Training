import { Component } from '@angular/core';
import {FormGroup,FormControl} from '@angular/forms';
// import {FormControl} from '@angular/forms';
@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'sample';
  // EnterForm = new FormGroup({
  //   name:new FormControl('')
  // })
  submit($event : any){
    console.log("Submitted",$event)
  }
}
