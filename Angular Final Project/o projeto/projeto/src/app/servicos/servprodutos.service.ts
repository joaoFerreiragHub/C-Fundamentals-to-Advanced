import { Injectable } from '@angular/core';
import { HttpClient, HttpErrorResponse } from '@angular/common/http';
import { Produtos } from '../modelos/produtos';
import { catchError, throwError } from 'rxjs';

@Injectable({
  providedIn: 'root',
})
export class ServprodutosService {
  constructor(private http: HttpClient) {}

  private processaErro(erro: HttpErrorResponse) {
    let mensagem = '';
    if (erro.status === 404) {
      mensagem = 'Página inexistente';
    } else {
      mensagem = 'Ocorreu um erro inesperado';
    }

    const err = new Error(mensagem);
    return throwError(() => err);
  }

  private urlAPI = 'http://localhost:3000/produtos';

  getProdutos() {
    return this.http.get<Produtos[]>(this.urlAPI);
  }

  getProduto(id: number) {
    return this.http.get<Produtos>(`${this.urlAPI}/${id}`);
  }

  getProdutosArr(id: number[]) {
    return this.http.get<Produtos[]>(`${this.urlAPI}/${id}`);
  }
  postProduto(infoProduto: Produtos) {
    return this.http.post<Produtos>(this.urlAPI, infoProduto);
  }

  putProduto(id: number, infoProduto: Produtos) {
    return this.http.put<Produtos>(`${this.urlAPI}/${id}`, infoProduto);
  }

  deleteProduto(id: number) {
    return this.http
      .delete<Produtos>(`${this.urlAPI}/${id}`)
      .pipe(catchError(this.processaErro));
  }
}
