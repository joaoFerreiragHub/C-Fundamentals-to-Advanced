import { map } from 'rxjs';
import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { WishlistComponent } from '../wishlist/wishlist.component';
import { ServutilizadoresService } from './servutilizadores.service';

@Injectable({
  providedIn: 'root',
})
export class WhislistService {
  private urlAPI = 'http://localhost:3000/utilizadores';
  constructor(
    private http: HttpClient,
    private servUtilziador: ServutilizadoresService
  ) {}

  getWishList() {}

  adicionarLista(produtoId: any) {
    return this.http.post(this.urlAPI, { id: produtoId });
  }

  removerLista(produtoId: any) {
    return this.http.delete(this.urlAPI + '/' + produtoId);
  }
}
