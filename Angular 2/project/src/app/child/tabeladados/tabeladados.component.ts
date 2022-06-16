import { Component, EventEmitter, Input, OnInit, Output } from '@angular/core';
import { Livro } from '../livro';

@Component({
  selector: 'app-tabeladados',
  templateUrl: './tabeladados.component.html',
  styleUrls: ['./tabeladados.component.css']
})
export class TabeladadosComponent implements OnInit {
  @Input() lista : Livro[] = [];
  // @Input() lista! : Livro[];
  @Output() idAMostrar : EventEmitter<number> = new EventEmitter();
  @Output() idAEliminar : EventEmitter<number> = new EventEmitter();
  @Output() idAAlterar : EventEmitter<number> = new EventEmitter();
  
  constructor() { }

  ngOnInit(): void {
  }

  mostraId(id: number) {
    console.log(id);
    this.idAMostrar.emit(id);
  }

  eliminaLivro(id : number, evento : any) {
    // alert(id);
    evento.stopPropagation();
    if (confirm("Confirma a eliminação do livro?")) {
      this.idAEliminar.emit(id);
    }
  }

  alteraLivro(id : number, evento : any) {
    evento.stopPropagation();
    this.idAAlterar.emit(id);
  }

}
