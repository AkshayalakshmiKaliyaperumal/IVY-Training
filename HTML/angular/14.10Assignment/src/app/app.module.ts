import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { AppComponent } from './app.component';
import { ReactiveFormsModule } from '@angular/forms';
import { NameComponent } from './name/name.component';
import { Name1Component } from './name1/name1.component';

@NgModule({
  declarations: [
    AppComponent,
    NameComponent,
    Name1Component
  ],
  imports: [
    BrowserModule,
    ReactiveFormsModule,
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
