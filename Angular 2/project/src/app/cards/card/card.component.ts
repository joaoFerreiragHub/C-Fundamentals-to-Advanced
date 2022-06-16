import { Component, Input, OnInit } from '@angular/core';

@Component({
  selector: 'app-card',
  templateUrl: './card.component.html',
  styleUrls: ['./card.component.css']
})
export class CardComponent implements OnInit {

  @Input() dados : any;

  // ../../../assets/landscape.jpg
  // card_imagem : string = "/assets/landscape.jpg";
  // subtitulo : string = "Joe Berardo";
  // titulo : string = "Governo aconselha avançar";
  // autor : string = "Leonete Botelho";

  constructor() { }

  // OnInit - lifecycle hook
  ngOnInit(): void {
    // console.log(this.dados);
    // console.log(this.dados.card_imagem);
    
    // this.card_imagem=this.dados.card_imagem;
    // this.subtitulo=this.dados.subtitulo;
    // this.titulo=this.dados.titulo;
    // this.autor=this.dados.autor;
  }

}
