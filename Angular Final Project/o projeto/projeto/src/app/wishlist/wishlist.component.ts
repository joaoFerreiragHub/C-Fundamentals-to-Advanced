import { Produtos } from './../modelos/produtos';
import { ServprodutosService } from './../servicos/servprodutos.service';
import { Utilizadores } from './../modelos/utilizadores';
import { ServutilizadoresService } from 'src/app/servicos/servutilizadores.service';
import { Component, Input, OnInit } from '@angular/core';
import { PartilharService } from '../servicos/partilhar.service';

@Component({
  selector: 'app-wishlist',
  templateUrl: './wishlist.component.html',
  styleUrls: ['./wishlist.component.css'],
})
export class WishlistComponent implements OnInit {
  constructor(
    private partilha: PartilharService,
    private servUtilizador: ServutilizadoresService,
    private servProdutos: ServprodutosService
  ) {}
  @Input() infoProduto: any;
  utilizador!: Utilizadores;
  whishlist!: Array<number>;
  // lista!: any[];
  // listaProdutos: any[] = [];
  // listaFiltrada: Produtos[] = [];
  // whishlist!: Produtos[];

  ngOnInit(): void {
    this.utilizador = this.partilha.getUtilizador();
    // this.whishlist = this.partilha.getDaWhishlist();
    // console.log(this.whishlist);

    if (this.utilizador.wishlist) this.whishlist = this.utilizador.wishlist;

    // this.getItems();
    // this.getLista();
    // this.whishlist = this.partilha.getWhishlist();
  }

  // getLista() {
  //   this.servProdutos
  //     .getProduto(this.infoProduto)
  //     .subscribe((produto: Produtos) => {
  //       this.infoProduto = produto;
  //     });
  // }

  // getItems() {
  //   this.servProdutos.getProdutos().subscribe((produtos: Produtos[]) => {
  //     this.listaProdutos = produtos;
  //   });

  //   this.listaFiltrada = this.listaProdutos.filter((produto) => {
  //     {
  //       this.lista.some((lista) => produto.id === lista);
  //     }
  //   });
  // }

  // remover(prod: any) {
  //   const pos = this.utilizador.wishlist?.includes(this.infoProduto);
  //   if (pos !== true) {
  //     const index = this.utilizador.wishlist?.indexOf(this.infoProduto.id);
  //     this.utilizador.wishlist?.splice(Number(index), 1);
  //   }

  //   this.servUtilizador
  //     .updateUtilizador(this.utilizador.id!, this.utilizador)
  //     .subscribe((utilizador: Utilizadores) => {
  //       this.utilizador.wishlist = utilizador.wishlist;
  //     });
  // }
}
