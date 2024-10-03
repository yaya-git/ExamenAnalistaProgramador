import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { HttpClientModule } from '@angular/common/http';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { RandomImagesComponent } from './random-images/random-images.component';
import { ApiService } from './services/api.service';
import { BuscarLibrosComponent } from './buscar-libros/buscar-libros.component';
import { FormsModule } from '@angular/forms';
import { BolaDeNieveComponent } from './bola-de-nieve/bola-de-nieve.component';
import { BienvenidosComponent } from './bienvenidos/bienvenidos.component';

@NgModule({
  declarations: [
    AppComponent,
    RandomImagesComponent,
    BuscarLibrosComponent,
    BolaDeNieveComponent,
    BienvenidosComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    FormsModule ,
    HttpClientModule,
    
  ],
  providers: [ApiService],
  bootstrap: [AppComponent]
})
export class AppModule { }
