import { Component, OnInit } from '@angular/core';
import { ApiService } from '../services/api.service';
import { HttpHeaders } from '@angular/common/http';

@Component({
  selector: 'app-random-images',
  templateUrl: './random-images.component.html',
  styleUrl: './random-images.component.css'
})
export class RandomImagesComponent implements OnInit {
  imageUrls: string[] = [];

  constructor(private apiService: ApiService) {
    this.generateRandomImages();
  }

  ngOnInit(): void {

  }

  generateRandomImages() {
    this.imageUrls = [];
    for (let i = 0; i < 10; i++) {
      this.imageUrls.push(`https://picsum.photos/200?random=${Math.random()}`);

    }
  }

  
}
