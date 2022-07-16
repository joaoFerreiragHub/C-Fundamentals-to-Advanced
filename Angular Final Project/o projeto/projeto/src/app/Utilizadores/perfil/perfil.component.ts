import {
  FormBuilder,
  FormControl,
  FormGroup,
  Validators,
} from '@angular/forms';
import { PartilharService } from './../../servicos/partilhar.service';
import { Utilizadores } from './../../modelos/utilizadores';
import { ServutilizadoresService } from 'src/app/servicos/servutilizadores.service';
import {
  Component,
  OnInit,
  TemplateRef,
  ViewEncapsulation,
} from '@angular/core';
import { Router } from '@angular/router';
import { ModalOptions } from 'ngx-bootstrap/modal';
import { BsModalRef } from 'ngx-bootstrap/modal';
import { NgbModal } from '@ng-bootstrap/ng-bootstrap';

@Component({
  selector: 'app-perfil',
  templateUrl: './perfil.component.html',
  styleUrls: ['./perfil.component.css'],
})
export class PerfilComponent implements OnInit {
  constructor(
    private ServUtilizadores: ServutilizadoresService,
    private partilha: PartilharService,
    private fb: FormBuilder,
    private modalServ: NgbModal
  ) {}

  modalRef?: BsModalRef;
  config: ModalOptions = { class: 'modal-lg' };
  listaUser!: Utilizadores[];
  utilizador!: Utilizadores;
  editProfileForm!: FormGroup;
  id!: number;
  item!: number;
  itens!: string;
  userID!: number;

  ngOnInit(): void {
    this.utilizador = this.partilha.getUtilizador();
    console.log(this.utilizador);
    this.userID = this.partilha.getID();
    // this.utilizador = this.item = JSON.parse(sessionStorage.getItem('id')!);
    // this.itens = this.objToString(this.item);
    // var numberValue = Number(this.itens);

    // this.getutilizador(this.utilizador.id!);

    this.editProfileForm = this.fb.group({
      nome: [''],
      email: [''],
      senha: [''],
      morada: [''],
      codigoPostal: [''],
      pais: [''],
      id: [''],
    });
  }
  getutilizador(id: number) {
    this.ServUtilizadores.getUtilizador(id).subscribe(
      (Utilizadores: Utilizadores) => {
        this.utilizador = Utilizadores;
        this.utilizador.id = Utilizadores.id;
      }
    );
  }

  updateUtilizador() {
    this.userID = this.partilha.getID();
    this.ServUtilizadores.updateUtilizador(
      this.userID,
      this.utilizador
    ).subscribe((res) => {
      console.log(res);
    });
  }

  openModal(targetModal: any, user: any) {
    this.modalServ.open(targetModal, {
      centered: true,
      backdrop: false,
    });

    this.editProfileForm.patchValue({
      nome: user.nome,
      email: user.email,
      senha: user.senha,
      morada: user.morada,
      codigoPostal: user.codigoPostal,
      pais: user.pais,
      id: user.id,
    });
  }

  onSubmit() {
    this.modalServ.dismissAll();
  }
}
