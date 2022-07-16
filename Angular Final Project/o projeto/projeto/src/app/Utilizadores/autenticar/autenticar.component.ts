import { NgbModal } from '@ng-bootstrap/ng-bootstrap';
import { PartilharService } from './../../servicos/partilhar.service';
import { AuthService } from './../../servicos/shared/auth.service';
import { Utilizadores } from './../../modelos/utilizadores';
import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { ServutilizadoresService } from 'src/app/servicos/servutilizadores.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-autenticar',
  templateUrl: './autenticar.component.html',
  styleUrls: ['./autenticar.component.css'],
})
export class AutenticarComponent implements OnInit {
  constructor(
    private servUtilizadores: ServutilizadoresService,
    private router: Router,
    private aService: AuthService,
    private modalServ: NgbModal,
    private partilha: PartilharService
  ) {}

  formLogin!: FormGroup;
  utilizador!: Utilizadores;
  isLoggedin: boolean = false;

  ngOnInit(): void {
    this.formLogin = new FormGroup({
      email: new FormControl('', [
        Validators.required,
        Validators.pattern(
          '[A-Za-zÀ-ÿ]{1,}[@][A-Za-zÀ-ÿ]{1,}[.][A-Za-zÀ-ÿ]{2,}'
        ),
      ]),
      senha: new FormControl('', [
        Validators.required,
        // Validators.pattern(
        //   '^(?=.*d)(?=.*[a-z])(?=.*[A-Z])(?=.*[a-zA-Z]).{8,}$'
        // ),
      ]),
    });
  }

  get email() {
    return this.formLogin.get('email')!;
  }

  get senha() {
    return this.formLogin.get('senha')!;
  }

  fazerLogin() {
    const login = this.formLogin.value;

    this.servUtilizadores.getUtilizadores().subscribe(
      (res) => {
        let user = res.find((a: any) => {
          return a.email === login.email && a.senha === login.senha;
        });
        if (user) {
          alert('Logou com suceso!');

          this.partilha.setUtilizador(user);
          this.partilha.setNome(user.nome);
          this.partilha.setId(user.id);
          if (this.formLogin.valid) {
            // sessionStorage.setItem('token', 'asdasdasdasdas');
            // sessionStorage.setItem('user', user.nome);
            // sessionStorage.setItem('id', JSON.stringify(user.id));
            // this.formLogin.value.email == 'joaomcf@gmail.com'
            //   ? sessionStorage.setItem('userType', 'admin')
            //   : sessionStorage.setItem('userType', 'cliente');

            this.isLoggedin = true;
            this.partilha.setEstado(this.isLoggedin);

            this.formLogin.reset();
            this.modalServ.dismissAll();
            this.router.navigate(['']);
          }
        } else {
          alert('Utilizador não está registado!');
        }
      },
      (err) => {
        alert('Erro inesperado!');
      }
    );
  }

  onSubmit() {
    this.modalServ.dismissAll();
  }
}
