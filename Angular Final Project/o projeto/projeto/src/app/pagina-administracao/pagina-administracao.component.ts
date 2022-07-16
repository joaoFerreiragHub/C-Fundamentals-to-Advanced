import { NgbModal } from '@ng-bootstrap/ng-bootstrap';
import { BsModalRef } from 'ngx-bootstrap/modal';
import { menuTipo } from './../modelos/menuTipo';
import { AdminDestaquesService } from './../servicos/admin-tipos.service';
import { Produtos } from './../modelos/produtos';
import {
  Component,
  EventEmitter,
  Input,
  OnInit,
  Output,
  TemplateRef,
} from '@angular/core';
import {
  FormBuilder,
  FormControl,
  FormGroup,
  Validators,
} from '@angular/forms';
import { ServprodutosService } from '../servicos/servprodutos.service';
import { BsModalService } from 'ngx-bootstrap/modal';
import { faCheck, faToggleOff } from '@fortawesome/free-solid-svg-icons';

@Component({
  selector: 'app-pagina-administracao',
  templateUrl: './pagina-administracao.component.html',
  styleUrls: ['./pagina-administracao.component.css'],
})
export class PaginaAdministracaoComponent implements OnInit {
  formProdutos!: FormGroup;
  modalRef?: BsModalRef;

  listaProdutos: Produtos[] = [];
  listaTipo!: any[];
  filtrada!: any[];

  nome!: string;
  idProduto!: number;
  message!: string;
  editar!: Produtos;

  faCheck = faCheck;
  faToggleOff = faToggleOff;

  @Input() pesquisaCorrente!: string;
  @Output() valorPesquisa: EventEmitter<string> = new EventEmitter();
  @Output() limpaPesquisa: EventEmitter<string> = new EventEmitter();
  editProfileForm: any;

  constructor(
    private servProdutos: ServprodutosService,
    private servTipos: AdminDestaquesService,
    private servModal: BsModalService,
    private fb: FormBuilder,
    private modalServ: NgbModal
  ) {}

  ngOnInit(): void {
    this.formProdutos = new FormGroup({
      nome: new FormControl('', [
        Validators.required,
        Validators.pattern('[a-zA-Z ]{3,40}'),
      ]),
      marca: new FormControl('', [
        Validators.required,
        Validators.pattern('[a-zA-Z ]{3,40}'),
      ]),
      tipo_de_produto: new FormControl('', Validators.required),
      cor: new FormControl('', Validators.required),
      preco: new FormControl('', Validators.required),
      descricao: new FormControl('', Validators.required),
      destaques: new FormControl('', Validators.required),
    });

    this.editProfileForm = this.fb.group({
      nome: [''],
      marca: [''],
      tipo_de_produto: [''],
      cor: [''],
      preco: [''],
      descricao: [''],
      destaques: [''],
    });

    this.todosProdutos();
    this.getTipos();
  }

  getTipos() {
    this.servTipos.gettipos().subscribe((tipos: menuTipo[]) => {
      this.listaTipo = tipos;
    });
  }

  inserirProduto() {
    let produto: Produtos = this.formProdutos.value;
    this.servProdutos.postProduto(produto).subscribe((produto: Produtos) => {
      this.todosProdutos();
      this.formProdutos.reset();
    });
  }

  todosProdutos() {
    this.servProdutos.getProdutos().subscribe((produtos: Produtos[]) => {
      this.listaProdutos = produtos;
    });
  }

  get produto() {
    // return this.formLivros.get("titulo")!;
    return this.formProdutos.controls['produto']!;
  }

  pesquisaProduto(nome: string) {
    this.filtrada = this.listaProdutos.filter((val) =>
      val.nome.toLocaleLowerCase().includes(this.nome.toLocaleLowerCase())
    );
    this.listaProdutos = this.filtrada;
    console.log(this.filtrada);
  }

  clearPesquisa() {
    this.limpaPesquisa.emit();
  }

  eliminaProduto(template: TemplateRef<any>, id: any) {
    this.modalRef = this.servModal.show(template, id);
    this.idProduto = id;
  }

  confirm() {
    this.servProdutos
      .deleteProduto(this.idProduto)
      .subscribe(() => this.todosProdutos());
    alert(`Foi eliminado o Produto com o id: ${this.idProduto}`);
    this.modalRef?.hide();
  }

  decline() {
    this.message = 'Declined!';
    this.modalRef?.hide();
  }

  getthisproductID(targetModal: any, produto: any) {
    this.idProduto = produto.id;
    this.servProdutos
      .getProduto(this.idProduto)
      .subscribe((produto) => (this.editar = produto));
    this.openModal(targetModal, produto);
  }

  openModal(targetModal: any, produto: any) {
    this.modalServ.open(targetModal, {
      centered: true,
      backdrop: false,
    });

    this.editProfileForm.patchValue({
      nome: this.editar.nome,
      marca: this.editar.marca,
      tipo_de_produto: this.editar.tipo_de_produto,
      cor: this.editar.cor,
      preco: this.editar.preco,
      descricao: this.editar.descricao,
      destaques: this.editar.destaques,
    });
  }

  limpa_pesquisa() {
    this.limpaPesquisa.emit();
  }

  reset_tabela() {
    this.todosProdutos();
  }
}
