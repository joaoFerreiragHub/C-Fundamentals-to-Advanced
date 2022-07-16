import { Produtos } from './../modelos/produtos';
import { Utilizadores } from './../modelos/utilizadores';
import { FormGroup } from '@angular/forms';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root',
})
export class PartilharService {
  constructor() {}

  formRegisto!: FormGroup;
  loggedin?: boolean;
  utilizador!: Utilizadores;
  nomeUtilizador!: string;
  userId!: number;
  whishlist!: Produtos[];

  setUtilizador(utilizador: Utilizadores) {
    this.utilizador = utilizador;
  }

  getUtilizador() {
    return this.utilizador;
  }

  setEstado(data: any) {
    this.loggedin = data;
  }

  getEstado() {
    return this.loggedin;
  }

  setNome(data: any) {
    this.nomeUtilizador = data;
  }
  getNome() {
    return this.nomeUtilizador;
  }

  setId(data: any) {
    this.userId = data;
  }

  getID() {
    return this.userId;
  }

  // setNaWhishlist(data: any) {
  //   this.whishlist = data;
  // }

  // getDaWhishlist() {
  //   return this.whishlist;
  // }
}
