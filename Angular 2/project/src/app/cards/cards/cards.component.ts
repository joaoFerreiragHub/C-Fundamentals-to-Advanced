import { Component, OnInit } from '@angular/core';
import { cardsList } from '../card_data';
import { Card } from '../card_type';

@Component({
  selector: 'app-cards',
  templateUrl: './cards.component.html',
  styleUrls: ['./cards.component.css']
})
export class CardsComponent implements OnInit {

  // card1 : any = {
  //   card_imagem : "/assets/landscape2.jpg",
  //   subtitulo : "Futebol",
  //   titulo : "Portugueses",
  //   autor : "Luís Francisco"
  // }

  //   card_imagem : string = "/assets/landscape.jpg";
  // subtitulo : string = "Joe Berardo";
  // titulo : string = "Governo aconselha avançar";
  // autor : string = "Leonete Botelho";

  cards : Card[] = cardsList;

  constructor() { }

  ngOnInit(): void {
  }

}
