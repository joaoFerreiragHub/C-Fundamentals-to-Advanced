import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { Livro } from '../livro';
// import { livros } from '../livros';
import { ServicoLivrosService } from '../servico-livros.service';

@Component({
  selector: 'app-gestaolivros',
  templateUrl: './gestaolivros.component.html',
  styleUrls: ['./gestaolivros.component.css']
})
export class GestaolivrosComponent implements OnInit {

  // listaLivrosOriginal: Livro[] = livros;
  listaLivros: Livro[] = [];

  infoLivro! : Livro;

  constructor(private servLivros : ServicoLivrosService, private router: Router) { }

  ngOnInit(): void {
    this.le_livros();
    // console.log(this.listaLivros);
  }

  le_livros() {
    // this.listaLivros=[...this.listaLivrosOriginal];
    this.listaLivros=this.servLivros.leLivros();
  }

  filtraLista(pesquisa : string) {
    // this.listaLivros=this.listaLivrosOriginal.filter(livro => livro.titulo.toUpperCase().includes(pesquisa.toUpperCase()));
    this.listaLivros=this.servLivros.filtraLista(pesquisa);
  }

  limpa_pesquisa() {
    this.le_livros();
  }

  mostraId(id: number) : void {
    // alert(id);
    this.router.navigateByUrl(`/child/${id}`);
    // this.router.navigate(['/child',id]);
  }

  insereLivro(livro: Livro) {
    console.log(livro);
    // let maximo : number=0;
    // for (let livro of this.listaLivrosOriginal) {
    //   if (livro.id!>maximo) {
    //     maximo=Number(livro.id);
    //   }
    // }
    // maximo++;

    // (livro.id! > max) ? Number(livro.id) : max
    // let maximo=this.listaLivrosOriginal.reduce((max,livro) => (livro.id! > max) ? +livro.id! : max,0)+1;

    // let lista=this.listaLivrosOriginal.map(livro => Number(livro.id));
    // let maximo = Math.max(...lista)+1;

    // console.log(maximo);
    // livro.id=maximo;
    // this.listaLivrosOriginal.push(livro);
    // ...livro = titulo: '1', editora: '2', ano_publicacao: 3, autor: '4', tipo: 'Biografia'
    // this.listaLivrosOriginal.push({ ...livro, id: maximo });
    // {titulo: '1', editora: '2', ano_publicacao: 3, autor: '4', tipo: 'Biografia', id: 5}

    let id=this.servLivros.insereLivro(livro);
    this.le_livros();
    alert(`Foi inserido um livro com o id: ${id}`);

  }

  eliminaId(id: number) {
    this.servLivros.eliminarLivro(id);
    this.le_livros();
    alert(`Foi eliminado o livro com o id: ${id}`);
  }

  editaLivro(id: number) {
    this.infoLivro = this.servLivros.extraiLivro(id);
    console.log(this.infoLivro);
  }

  alteraLivro(livro: Livro) {
    this.servLivros.actualizarLivro(livro);
    this.le_livros();
    alert(`Foi alterado o livro com o id: ${livro.id}`);
  }

}
