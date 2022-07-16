import { Utilizadores } from './../modelos/utilizadores';
import { ServutilizadoresService } from 'src/app/servicos/servutilizadores.service';
import { Produtos } from './../modelos/produtos';
import { Component, OnInit, Input } from '@angular/core';
import { ServprodutosService } from '../servicos/servprodutos.service';
import { ActivatedRoute } from '@angular/router';
import { Router } from '@angular/router';
import { PartilharService } from '../servicos/partilhar.service';
import { faStar } from '@fortawesome/free-regular-svg-icons';
import { faStar as faStarSolid } from '@fortawesome/free-solid-svg-icons';
import { faItunesNote } from '@fortawesome/free-brands-svg-icons';

@Component({
  selector: 'app-paginaprodutos',
  templateUrl: './paginaprodutos.component.html',
  styleUrls: ['./paginaprodutos.component.css'],
})
export class PaginaprodutosComponent implements OnInit {
  constructor(
    private router: Router,
    private rotaActiva: ActivatedRoute,
    private servProdutos: ServprodutosService,
    private partilha: PartilharService,
    private servUtilizadores: ServutilizadoresService
  ) {}

  @Input() produtoItem!: Produtos;

  // Parametros do Dropdown
  peca!: string; // Tipo de peca(opcao dropdown)
  opcoes!: string; // opcao do menu

  // Listas de Produtos Checkboxes
  listaCores: string[] = []; // Cores de Produtos
  listatipo: string[] = []; // Tipo de Produtos

  ListaOpcoes: Produtos[] = []; // Genero do utilizador dos produtos
  ListaPecas: Produtos[] = []; // tipo dos produtos
  listafiltrada: Produtos[] | null = []; //Lista Final
  listaCorTipo: Produtos[] | null = []; //Lista cruzada de cores e pecas

  utilizador!: Utilizadores;
  max: number = 6;

  ngOnInit(): void {
    this.rotaActiva.paramMap.subscribe((params) => {
      this.peca = params.get('peca')!;
    });
    this.rotaActiva.paramMap.subscribe((params) => {
      this.opcoes = params.get('opcoes')!;
    });
    this.utilizador = this.partilha.getUtilizador();
    this.getCorCheckBox();
    this.getTipoCheckBox();

    if (this.peca !== 'Todos') {
      this.getBuscaPorPeca();
      this.router.routeReuseStrategy.shouldReuseRoute = function () {
        return false;
      };
    } else {
      this.getGeneroETipos();
      this.router.routeReuseStrategy.shouldReuseRoute = function () {
        return false;
      };
    }
  }

  alterarNumero() {
    this.max = this.max + 6;
  }

  getCorCheckBox() {
    this.servProdutos.getProdutos().subscribe((produtos: Produtos[]) => {
      this.listaCores = produtos.map((p) => p.cor);
      this.listaCores = this.listaCores.filter(
        (cor, c) => c === this.listaCores.indexOf(cor)
      );
    });
  }

  getTipoCheckBox() {
    this.servProdutos.getProdutos().subscribe((produtos: Produtos[]) => {
      this.listatipo = produtos.map((t) => t.tipo_de_produto);
      this.listatipo = this.listatipo.filter(
        (tipo, t) => t === this.listatipo.indexOf(tipo)
      );
    });
  }

  getGeneroETipos() {
    this.rotaActiva.paramMap.subscribe((params) => {
      this.opcoes = params.get('opcoes')!;
    });
    this.servProdutos.getProdutos().subscribe((produtos: Produtos[]) => {
      this.ListaOpcoes = produtos.filter(
        (produtos) => produtos.opcoes === this.opcoes
      );
      this.listafiltrada = this.ListaOpcoes;
    });

    // this.rotaActiva.paramMap.subscribe((params) => {
    //   this.peca = params.get('peca')!;
    // });
    // this.servProdutos.getProdutos().subscribe((produtos: Produtos[]) => {
    //   this.ListaPecas = produtos.filter(
    //     (produtos) => produtos.tipo_de_produto === this.peca
    //   );
    //   this.listafiltrada = this.ListaPecas;
    // });
  }

  getBuscaPorPeca() {
    this.rotaActiva.paramMap.subscribe((params) => {
      this.opcoes = params.get('opcoes')!;
    });
    this.servProdutos.getProdutos().subscribe((produtos: Produtos[]) => {
      this.ListaOpcoes = produtos.filter(
        (produtos) => produtos.opcoes === this.opcoes
      );
      this.listafiltrada = this.ListaOpcoes.filter(
        (p) => p.tipo_de_produto === this.peca
      );
    });
  }

  getFiltraPeca(peca: any) {
    this.listaCorTipo = this.ListaOpcoes.filter(
      (produto) => produto.tipo_de_produto === peca
    );
    this.listafiltrada = this.listaCorTipo;
  }

  getFiltraCor(cor: any) {
    this.listafiltrada = this.listaCorTipo?.filter(
      (produto) => produto.cor === cor
    )!;
  }
}
