import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-teste',
  templateUrl: './teste.component.html',
  styleUrls: ['./teste.component.css']
})
export class TesteComponent implements OnInit {

  nome_componente: string = "Teste";
  // nome_componente : string = ""; // empty string
  // nome_componente! : string;
  nome_componente2: string = "Teste2".toUpperCase();
  localidade: string = "Ermesinde";

  imagem1: string = "/assets/landscape.jpg";
  imagem2: string = "landscape.jpg";

  collapse_escondido : boolean = true;
  collapse_visivel : boolean = false;

  constructor() { 
    // this.nome_componente="Teste";
  }

  ngOnInit(): void {
  }

  mostrar_nome_componente() {
    let valor="Teste";
    valor=valor.toUpperCase();
    return valor;
    // return "Teste".toUpperCase();
  }

  muda_imagem() {
    this.imagem1="/assets/landscape2.jpg";
  }

  mostra_collapse() {
    // if (this.collapse_escondido===true) {
    // if (this.collapse_escondido) {
    //   this.collapse_escondido=false;
    // } else {
    //   this.collapse_escondido=true;
    // }
    // this.collapse_escondido=(this.collapse_escondido) ? false : true;
    this.collapse_escondido=!this.collapse_escondido;
  }

  mostra_collapse2() {
    this.collapse_visivel=!this.collapse_visivel;
  }

}

// document.getElementById("botao")?.addEventListener("click", function() {

// });