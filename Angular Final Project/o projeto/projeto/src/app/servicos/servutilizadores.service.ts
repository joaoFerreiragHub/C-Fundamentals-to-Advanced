import { Utilizadores } from './../modelos/utilizadores';
import { Injectable } from '@angular/core';
import { HttpClient, HttpErrorResponse } from '@angular/common/http';
import { catchError, throwError } from 'rxjs';
import { map } from 'rxjs';

@Injectable({
  providedIn: 'root',
})
export class ServutilizadoresService {
  constructor(private http: HttpClient) {}

  private urlAPI = 'http://localhost:3000/utilizadores';

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

  getUtilizadores() {
    return this.http.get<Utilizadores[]>(this.urlAPI);
  }

  getUtilizador(id: number) {
    return this.http.get<Utilizadores>(`${this.urlAPI}/${id}`);
  }
  postUtilizador(infoUser: Utilizadores) {
    return this.http.post<Utilizadores>(this.urlAPI, infoUser);
  }

  updateUtilizador(id: number, infoUser: Utilizadores) {
    return this.http.put<Utilizadores>(`${this.urlAPI}/${id}`, infoUser);
  }

  filtraUser(filtroUser: string) {
    return this.http.get<Utilizadores>(`${this.urlAPI}/id${filtroUser}`);
  }

  deleteUser(id: number) {
    return this.http
      .delete<Utilizadores>(`${this.urlAPI}/${id}`)
      .pipe(catchError(this.processaErro));
  }
}
