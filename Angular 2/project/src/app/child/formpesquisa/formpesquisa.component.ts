import { Component, EventEmitter, OnInit, Output } from '@angular/core';

@Component({
  selector: 'app-formpesquisa',
  templateUrl: './formpesquisa.component.html',
  styleUrls: ['./formpesquisa.component.css']
})
export class FormpesquisaComponent implements OnInit {

  @Output() valorPesquisa : EventEmitter<string> = new EventEmitter();
  @Output() limpaPesquisa : EventEmitter<string> = new EventEmitter();

  constructor() { }

  ngOnInit(): void {
  }

  limpa_pesquisa() {
    this.limpaPesquisa.emit();
  }

  processa_pesquisa(pesquisa : string) {
    // "pesquisa" é o payload
    this.valorPesquisa.emit(pesquisa);
  }
}
