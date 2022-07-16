import { Produtos } from './../modelos/produtos';
import { PartilharService } from './../servicos/partilhar.service';
import { ServprodutosService } from './../servicos/servprodutos.service';
import { Utilizadores } from './../modelos/utilizadores';
import { Component, Input, OnInit } from '@angular/core';

@Component({
  selector: 'app-favoritos',
  templateUrl: './favoritos.component.html',
  styleUrls: ['./favoritos.component.css'],
})
export class FavoritosComponent implements OnInit {
  @Input() favoritos: any;
  Utilizador!: Utilizadores;
  constructor(
    private servProduto: ServprodutosService,
    private partilha: PartilharService
  ) {}

  ngOnInit(): void {
    this.Utilizador = this.partilha.getUtilizador();
    this.getFavoritos();
  }

  getFavoritos() {
    this.servProduto
      .getProduto(this.favoritos)
      .subscribe((produto: Produtos) => {
        this.favoritos = produto;
      });
  }

  remover() {
    if (this.Utilizador) {
      const index = this.Utilizador.wishlist?.indexOf(this.favoritos.id);
      if (index !== -1) {
        this.Utilizador.wishlist?.splice(Number(index), 1);
      }
    }
  }
}
