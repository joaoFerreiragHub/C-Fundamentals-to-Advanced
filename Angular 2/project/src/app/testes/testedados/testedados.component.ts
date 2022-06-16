import { Component, ElementRef, OnInit, Renderer2, ViewChild } from '@angular/core';
import { Pessoa } from '../pessoa';
import { pessoas } from '../pessoas';

// export interface Pessoa {
//   id?: number,
//   nome: string,
//   localidade: string,
//   casado: boolean
// }

@Component({
  selector: 'app-testedados',
  templateUrl: './testedados.component.html',
  styleUrls: ['./testedados.component.css']
})
export class TestedadosComponent implements OnInit {
  // #nomepesquisa no template
  // @ViewChild('nomepesquisa') elPesquisa! : ElementRef;
  // parecido com
  // let elPesquisa=document.getElementById("nomepesquisa")

  // listaPessoas : Array<Pessoa> = [];
  // listaPessoas : Pessoa[] = [];
  listaPessoas : Pessoa[] = [];
  listaPessoasOriginal : Pessoa [] = pessoas;

  // DI - Dependency Injection
  constructor(private servicorenderer: Renderer2) { 
    console.log(this.listaPessoas);
    this.le_pessoas();
  }

  ngOnInit(): void {
  }

  le_pessoas() {
    this.listaPessoas=[...this.listaPessoasOriginal];
  }

  mostraId(id : number) {
    alert(id);
  }

  limpa_pesquisa() {
    this.le_pessoas();
    // colocar o focus no campo "pesquisa"
    // this.elPesquisa.nativeElement.focus();
    this.servicorenderer.selectRootElement("#pesquisa").focus();
  }

  processa_pesquisa(pesquisa : string) {
    // alert("Form submetido!");
    // alert(pesquisa);
    this.listaPessoas=this.listaPessoasOriginal.filter(pessoa => pessoa.nome.toUpperCase().includes(pesquisa.toUpperCase()));
  }
}
