import { Injectable } from '@angular/core';
import { Livro } from './livro';
import { livros } from './livros';

@Injectable({
  providedIn: 'root'
})
export class ServicoLivrosService {

  private listaLivros: Livro[] = livros;

  constructor() { }

  //  CRUD - Create, Read (inclui extrair todos os registos, pesquisar, filtrar e extrair apenas um registo), Update e Delete

  leLivros() {
    return this.listaLivros;
  }

  filtraLista(pesquisa : string) {
    return this.listaLivros.filter(livro => livro.titulo.toUpperCase().includes(pesquisa.toUpperCase()));
  }

  insereLivro(livro: Livro) {
    let proximoId=this.listaLivros.reduce((max,livro) => (livro.id! > max) ? +livro.id! : max,0)+1;

    this.listaLivros.push({ ...livro, id: proximoId });

    // return { ...livro, id: proximoId }
    return proximoId;
  }

  // Extrair livro
  extraiLivro(id: number) {
    // return this.listaLivros.filter(livro => livro.id===id)[0];
    return this.listaLivros.find(livro => livro.id===id)!;
  }

  // Eliminar livro
  eliminarLivro(id: number) {
    this.listaLivros=this.listaLivros.filter(livro => livro.id!==id);
  }

  // Actualizar livro
  // actualizarLivro(id: number, livro: Livro) {
  actualizarLivro(livroAlterado: Livro) {
    console.log("Actualizar livro:",livroAlterado);
    // encontrar livro (posição no array) que tenha o id passado
    let posicao=this.listaLivros.findIndex(livro => livro.id===livroAlterado.id)!;
    // actualizar propriedades
    // this.listaLivros[posicao].titulo= livroAlterado.titulo;
    // this.listaLivros[posicao].editora=livroAlterado.editora;
    // this.listaLivros[posicao].ano_publicacao= livroAlterado.ano_publicacao;
    // this.listaLivros[posicao].autor=livroAlterado.autor;
    // this.listaLivros[posicao].tipo=livroAlterado.tipo;
    this.listaLivros[posicao]={
      id: livroAlterado.id,
      titulo: livroAlterado.titulo,
      editora: livroAlterado.editora,
      ano_publicacao: livroAlterado.ano_publicacao,
      autor: livroAlterado.autor,
      tipo: livroAlterado.tipo
    }

  }
}
