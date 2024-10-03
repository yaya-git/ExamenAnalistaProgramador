import { Component,ViewChild } from '@angular/core';
import { RandomImagesComponent } from './random-images/random-images.component';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrl: './app.component.css'
})
export class AppComponent {
  @ViewChild('randomImages', { static: false }) randomImages: RandomImagesComponent | undefined;
  title = 'random-image';
}
