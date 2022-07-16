import { Component, OnInit, ViewChild } from '@angular/core';
import { BsModalRef } from 'ngx-bootstrap/modal';
import { Utilizadores } from './modelos/utilizadores';
import {
  faYoutube,
  faFacebook,
  faTwitter,
  faInstagram,
  faPinterest,
} from '@fortawesome/free-brands-svg-icons';
import {
  faArrowAltCircleRight,
  faUser,
  faClipboard,
} from '@fortawesome/free-regular-svg-icons';
import {
  faUserPlus,
  faArrowRight,
  faArrowCircleRight,
  faCheck,
} from '@fortawesome/free-solid-svg-icons';
import { faClipboardList } from '@fortawesome/free-solid-svg-icons';
import { faUserEdit } from '@fortawesome/free-solid-svg-icons';
import { PartilharService } from './servicos/partilhar.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css'],
})
export class AppComponent implements OnInit {
  constructor() {}

  listaUsers: Utilizadores[] = [];
  modalRef?: BsModalRef;

  // @ViewChild(BotoesComponent) nomeUtilizador!: BotoesComponent;
  // ngAfterContentChecked(): void {
  //   //Called after every check of the component's or directive's content.
  //   //Add 'implements AfterContentChecked' to the class.
  //   this.nomeUtilizador.nomeUtilizador = this.partilha.getNome();
  // }
  config = {
    animated: true,
    keyboard: true,
    backdrop: true,
    ignoreBackdropClick: false,
    class: 'my-modal',
  };

  ngOnInit(): void {}

  title = 'H&M';
  faUserPlus = faUserPlus;
  faArrowCircleRight = faArrowCircleRight;
  faClipboard = faClipboard;
  faUser = faUser;
  faArrowAltCircleRight = faArrowAltCircleRight;
  faArrowRight = faArrowRight;
  faFacebook = faFacebook;
  faYoutube = faYoutube;
  faTwitter = faTwitter;
  faInstagram = faInstagram;
  faPinterest = faPinterest;
  faWishlist = faClipboardList;
  faLog = faArrowAltCircleRight;
  faRegisto = faUserPlus;
  faPerfil = faUserEdit;

  myInterval = 3000;
  activeSlideIndex = 0;
  slides: { image: string; text?: string }[] = [
    { image: 'src/assets/slides/slider1.jpg' },
    { image: 'src/assets/slides/slider2.jpg' },
    { image: 'src/assets/slides/slider3.jpg' },
  ];
}
