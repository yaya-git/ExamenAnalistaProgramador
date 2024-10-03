import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { RandomImagesComponent } from './random-images/random-images.component';
import { BuscarLibrosComponent } from './buscar-libros/buscar-libros.component';
import { BolaDeNieveComponent } from './bola-de-nieve/bola-de-nieve.component';
import { BienvenidosComponent } from './bienvenidos/bienvenidos.component';

const routes: Routes = [{
  path:'',component:BienvenidosComponent
},
  {
  path:'random-img', component:RandomImagesComponent,
  
},{
  path:'libros', component:BuscarLibrosComponent,
},{
  path:'bola-de-nieve', component:BolaDeNieveComponent,
},{
  path:'bienvenidos',component:BienvenidosComponent
}];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
