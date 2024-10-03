import { inject, Injectable } from '@angular/core';

import { Observable} from "rxjs";
import { map, catchError } from 'rxjs/operators';
import { environment } from "../../environments/environment";
import { HttpClient } from '@angular/common/http';

// @Injectable({ providedIn: 'root' })
export class ApiService {
    private baseUrl = environment.apiURL;
    private apiGoogle = environment.apiGoogle;
    private http = inject(HttpClient);
    constructor() {}
    

  // Petición GET
  getData(method:string, params?: string): Observable<any> {
    if (params == undefined)
      params = '';
    // if(type == undefined)
    //     requestOptions.responseType = 'json';

    console.log('Link ', `${this.baseUrl}/${method}${params}`);
    return this.http.get(`${this.baseUrl}/${method}${params}`);
  }

  buscarLibro(query: string): Observable<any>{
    return this.http.get(`${this.apiGoogle}/books/v1/volumes?q=${query}`);
  }
   


}



