import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = '13.10Assignment';
  greet(event:any){
    console.log(event);
  }
  greeting: string = 'GREET';
  // setvalue(){
  //   this.greeting = "GREET";
  // }
  date = new Date();
}
