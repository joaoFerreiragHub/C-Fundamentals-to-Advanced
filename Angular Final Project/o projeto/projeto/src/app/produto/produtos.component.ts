import { Produtos } from '../modelos/produtos';
import { Component, OnInit, Input } from '@angular/core';
import { ServprodutosService } from '../servicos/servprodutos.service';
import { ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-produtos',
  templateUrl: './produtos.component.html',
  styleUrls: ['./produtos.component.css'],
})
export class ProdutosComponent implements OnInit {
  constructor(
    private rotaActiva: ActivatedRoute,
    private servProdutos: ServprodutosService
  ) {}

  id!: number;
  produto!: Produtos;

  ngOnInit(): void {
    this.rotaActiva.paramMap.subscribe((params) => {
      this.id = Number(params.get('id'));
    });
    if (!isNaN(this.id)) {
      this.servProdutos
        .getProduto(this.id)
        .subscribe((produtoSelecionado: Produtos) => {
          this.produto = produtoSelecionado;
        });
    }
  }
}
