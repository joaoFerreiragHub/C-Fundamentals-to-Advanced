import { Utilizadores } from './../modelos/utilizadores';
import { Component, OnInit } from '@angular/core';
import { destaques } from './../modelos/destaques';
import { PartilharService } from '../servicos/partilhar.service';
import { ServprodutosService } from '../servicos/servprodutos.service';
import { Produtos } from '../modelos/produtos';

@Component({
  selector: 'app-pagina-principal',
  templateUrl: './pagina-principal.component.html',
  styleUrls: ['./pagina-principal.component.css'],
})
export class PaginaPrincipalComponent implements OnInit {
  // listaDestaque: destaques[] = [];
  listaDestaque: Produtos[] = [];

  constructor(
    // private servDestaques: ServdestaquesService,
    private serProdutos: ServprodutosService
  ) {}

  ngOnInit(): void {
    this.buscaDestaques();
  }

  // buscaDestaques() {
  //   this.servDestaques.getDestaques().subscribe({
  //     next: (Destaques: destaques[]) => {
  //       console.log(Destaques);
  //       this.listaDestaque = Destaques;
  //     },
  //   });
  // }

  buscaDestaques() {
    this.serProdutos.getProdutos().subscribe((produtos: Produtos[]) => {
      this.listaDestaque = produtos.filter(
        (produtos) => produtos.destaques === true
      );
    });
  }
}
