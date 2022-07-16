import { menuTipo } from './../modelos/menuTipo';
import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root',
})
export class AdminDestaquesService {
  private urlAPI = 'http://localhost:3000/menuTipo';

  constructor(private http: HttpClient) {}

  gettipos() {
    return this.http.get<menuTipo[]>(this.urlAPI);
  }
}
