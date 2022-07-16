import { Utilizadores } from './../modelos/utilizadores';
import { Component, Input, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { ServutilizadoresService } from '../servicos/servutilizadores.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-pagina-registos',
  templateUrl: './pagina-registos.component.html',
  styleUrls: ['./pagina-registos.component.css'],
})
export class PaginaRegistosComponent implements OnInit {
  constructor(
    private servUtilizadores: ServutilizadoresService,
    private router: Router,
    private ServUtilizadores: ServutilizadoresService
  ) {}

  formRegisto!: FormGroup;
  utilizador!: Utilizadores;

  id!: number;
  updateUtilizadores = {
    nome: '',
    email: '',
    senha: '',
    morada: '',
    codigoPostal: '',
    pais: '',
  };

  ngOnInit(): void {
    this.formRegisto = new FormGroup({
      nome: new FormControl('', [Validators.required, Validators.minLength(3)]),
      email: new FormControl('', [
        Validators.required,
        Validators.pattern(
          '[A-Za-zÀ-ÿ]{1,}[@][A-Za-zÀ-ÿ]{1,}[.][A-Za-zÀ-ÿ]{2,}'
        ),
      ]),
      senha: new FormControl('', [
        Validators.required,
        Validators.pattern(
          '^(?=.*d)(?=.*[a-z])(?=.*[A-Z])(?=.*[a-zA-Z]).{8,}$'
        ),
      ]),
      morada: new FormControl('', [
        Validators.required,
        Validators.minLength(5),
      ]),
      codigoPostal: new FormControl('', [
        Validators.required,
        Validators.pattern(/\d{4}\-\d{3}/),
      ]),
      pais: new FormControl('', [Validators.required, Validators.minLength(5)]),
      whishlist: new FormControl([]),
    });
  }

  registoUtilizador() {
    let utilizador: Utilizadores = this.formRegisto.value;
    this.servUtilizadores.postUtilizador(utilizador).subscribe(
      (utilizador: Utilizadores) => {
        alert('Registado com Sucesso!');
        this.formRegisto.reset();
        this.router.navigate(['autenticar']);
      },
      (err) => {
        alert('Erro Inesperado!');
      }
    );
  }

  getutilizador(id: number) {
    this.ServUtilizadores.getUtilizador(this.id).subscribe(
      (Utilizadores: Utilizadores) => {
        this.utilizador = Utilizadores;
      }
    );
  }

  editarUtilizador(utilizador: any) {
    this.updateUtilizadores = utilizador;
  }

  //validators
  get nome() {
    return this.formRegisto.get('nome')!;
  }
  get senha() {
    return this.formRegisto.get('senha')!;
  }
  get email() {
    return this.formRegisto.get('email')!;
  }
  get morada() {
    return this.formRegisto.get('morada')!;
  }
  get codigoPostal() {
    return this.formRegisto.get('codigoPostal')!;
  }
  get pais() {
    return this.formRegisto.get('pais')!;
  }
}
