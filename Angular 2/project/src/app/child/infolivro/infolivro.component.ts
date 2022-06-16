import { Location } from '@angular/common';
import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { Livro } from '../livro';
import { ServicoLivrosService } from '../servico-livros.service';

@Component({
  selector: 'app-infolivro',
  templateUrl: './infolivro.component.html',
  styleUrls: ['./infolivro.component.css']
})
export class InfolivroComponent implements OnInit {

  id: number = 0;
  livro! : Livro;

  constructor(private rotaActiva: ActivatedRoute, private servlivros: ServicoLivrosService, private localizacao: Location) { }

  ngOnInit(): void {
    // testar a existência do parâmetro com o método has()
    this.id=Number(this.rotaActiva.snapshot.paramMap.get('id'));
    // quando o id não é numérico, o valor retornado é NaN (Not a Number)
    // console.log(typeof this.id); // number se id=NaN
    if (!isNaN(this.id)) {
      // se for um número
      this.livro=this.servlivros.extraiLivro(this.id);
    }
    // else {
      // this.router.navigateByUrl('/child/');
    // }
  }

  voltarAtras() {
    this.localizacao.back();
  }

}
