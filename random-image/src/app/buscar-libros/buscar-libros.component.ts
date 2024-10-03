import { Component } from '@angular/core';
import { ApiService } from '../services/api.service';

@Component({
  selector: 'app-buscar-libros',
  templateUrl: './buscar-libros.component.html',
  styleUrl: './buscar-libros.component.css'
})
export class BuscarLibrosComponent {

  searchQuery: string = '';
  books: any[] = [];

  constructor(private apiService: ApiService) { }

  searchBooks() {
    if (this.searchQuery) {
      this.apiService.buscarLibro(this.searchQuery).subscribe((response: any) => {
        this.books = response.items || [];
      });
    }
  }
}
