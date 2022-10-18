import { Component, OnInit } from '@angular/core';
import {FormGroup , FormControl} from '@angular/forms';
@Component({
  selector: 'app-name1',
  templateUrl: './name1.component.html',
  styleUrls: ['./name1.component.css']
})
export class Name1Component {
  detailsform = new FormGroup({
    name : new FormControl(''),
    id : new FormControl(''),
    age : new FormControl(''),
    address : new FormGroup({
      city : new FormControl(''),
      country : new FormControl('')
    })
  })
  Submit(){
    console.log(this.detailsform.value);
  }
}
