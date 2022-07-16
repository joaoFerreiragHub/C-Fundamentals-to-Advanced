import { Component, Input, OnInit } from '@angular/core';
import { Utilizadores } from './../modelos/utilizadores';
import { ServutilizadoresService } from 'src/app/servicos/servutilizadores.service';
import { Produtos } from './../modelos/produtos';
import { ServprodutosService } from '../servicos/servprodutos.service';
import { ActivatedRoute } from '@angular/router';
import { Router } from '@angular/router';
import { PartilharService } from '../servicos/partilhar.service';
import { faStar } from '@fortawesome/free-regular-svg-icons';
import { faStar as faStarSolid } from '@fortawesome/free-solid-svg-icons';
import { faItunesNote } from '@fortawesome/free-brands-svg-icons';

@Component({
  selector: 'app-info-produto',
  templateUrl: './info-produto.component.html',
  styleUrls: ['./info-produto.component.css'],
})
export class InfoProdutoComponent implements OnInit {
  constructor(
    private router: Router,
    private rotaActiva: ActivatedRoute,
    private servProdutos: ServprodutosService,
    private partilha: PartilharService,
    private servUtilizadores: ServutilizadoresService
  ) {}

  @Input() infoProduto: any;

  utilizador!: Utilizadores;
  max: number = 6;
  aux: any;

  faStar = faStar;
  faStarSolid = faStarSolid;

  ngOnInit(): void {
    this.utilizador = this.partilha.getUtilizador();
    this.aux = this.faStar;

    if (
      this.utilizador &&
      this.utilizador.wishlist?.includes(this.infoProduto.id)
    ) {
      this.aux = this.faStarSolid;
    }
  }

  adicionarLista() {
    if (this.aux === this.faStarSolid) {
      const pos = this.utilizador.wishlist?.indexOf(this.infoProduto.id);
      if (pos !== -1) {
        this.utilizador.wishlist?.splice(pos!, 1);
        this.aux = this.faStar;
      }
    } else {
      this.aux = this.faStarSolid;
      if (!this.utilizador.wishlist) {
        this.utilizador.wishlist = [];
      }
      // this.partilha.setNaWhishlist(this.infoProduto);
      this.utilizador.wishlist.push(this.infoProduto.id);
    }

    this.servUtilizadores
      .updateUtilizador(this.utilizador.id!, this.utilizador)
      .subscribe((utilizador: Utilizadores) => {
        this.utilizador.wishlist = utilizador.wishlist;
      });
  }
}
