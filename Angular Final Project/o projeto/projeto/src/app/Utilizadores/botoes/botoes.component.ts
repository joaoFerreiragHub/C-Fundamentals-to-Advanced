import { PartilharService } from './../../servicos/partilhar.service';
import { AutenticarComponent } from './../autenticar/autenticar.component';
import { Component, OnInit } from '@angular/core';
import { faClipboardList } from '@fortawesome/free-solid-svg-icons';
import { faArrowAltCircleRight } from '@fortawesome/free-solid-svg-icons';
import { faUserPlus, faArrowRight } from '@fortawesome/free-solid-svg-icons';
import { faUserEdit } from '@fortawesome/free-solid-svg-icons';
import { BsModalService, BsModalRef } from 'ngx-bootstrap/modal';
import { ServutilizadoresService } from 'src/app/servicos/servutilizadores.service';

@Component({
  selector: 'app-botoes',
  templateUrl: './botoes.component.html',
  styleUrls: ['./botoes.component.css'],
})
export class BotoesComponent implements OnInit {
  modalRef?: BsModalRef;
  faWishlist = faClipboardList;
  faLog = faArrowAltCircleRight;
  faRegisto = faUserPlus;
  faPerfil = faUserEdit;
  faARight = faArrowRight;

  constructor(
    private modalService: BsModalService,
    private partilha: PartilharService,
    private userService: ServutilizadoresService
  ) {}

  nomeUtilizador = '';
  isLoggedin!: boolean;

  //Session Storage:
  // item!: any;
  // id!: number;

  ngOnInit(): void {
    // this.nomeUtilizador = sessionStorage.getItem('user')!;
    // this.item = JSON.parse(sessionStorage.getItem('id')!);
    this.isLoggedin = this.partilha.getEstado()!;
  }

  openLogin() {
    this.modalRef = this.modalService.show(AutenticarComponent);
  }

  openLogout() {
    // sessionStorage.removeItem('token');
    this.isLoggedin = false;
    this.partilha.setEstado(this.isLoggedin);
  }

  verificarLogin() {
    // return sessionStorage.getItem('token');
    this.nomeUtilizador = this.partilha.getNome();
    return (this.isLoggedin = this.partilha.getEstado()!);
  }
}
