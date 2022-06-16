import { Component, EventEmitter, Input, OnInit, Output, OnChanges, SimpleChanges } from '@angular/core';
import { FormControl, FormGroup, SelectControlValueAccessor, Validators } from '@angular/forms';
import { tipos_livros } from '../tipos_livros';

@Component({
  selector: 'app-insere-livros',
  templateUrl: './insere-livros.component.html',
  styleUrls: ['./insere-livros.component.css']
})
export class InsereLivrosComponent implements OnInit, OnChanges {

  @Output() novoLivro : EventEmitter<any> = new EventEmitter()
  @Output() livroAlterado : EventEmitter<any> = new EventEmitter()

  // @Input() infoLivro : any;

  @Input()
  set infoLivro(info: any) {
    if (info!==undefined) {
      this.formLivros.setValue({
        titulo: info.titulo,
        editora: info.editora,
        ano_publicacao: info.ano_publicacao,
        autor: info.autor,
        tipo: info.tipo
      });
      this.idAAlterar=info.id;
      this.emInsercao=false;
    }
  }

  tipos: string[] = tipos_livros;
  formLivros! : FormGroup;
  emInsercao : boolean = true;
  idAAlterar! : number;
  
  constructor() { }

  ngOnInit(): void {
    let hoje=new Date();
    let ano=hoje.getFullYear();
    this.formLivros = new FormGroup({
      titulo: new FormControl('',[Validators.required,Validators.minLength(3)]),
      editora: new FormControl('',Validators.pattern('[a-zA-Z ]{3,40}')),
      ano_publicacao: new FormControl(null,Validators.max(ano)),
      autor: new FormControl('', {initialValueIsDefault: true}),
      tipo: new FormControl('')
    });

    // this.formLivros.setValue({
    //   titulo: "1",
    //   editora: "2",
    //   ano_publicacao: 2022,
    //   autor: "Pedro Remoaldo",
    //   tipo: "Humor"
    // });
    // this.formLivros.get('titulo')?.setValue('Outro título');
    // this.formLivros.patchValue({
    //   titulo: "1",
    //   ano_publicacao: 2022
    // });
  }
  
  // lifecycle hook
  ngOnChanges(changes: SimpleChanges) {
    // // outras propriedades - previousValue e firstChange
    // let info=changes['infoLivro'].currentValue;
    // // console.log(changes['infoLivro']);
    // if (info!==undefined) {
    //   this.formLivros.setValue({
    //       titulo: info.titulo,
    //       editora: info.editora,
    //       ano_publicacao: info.ano_publicacao,
    //       autor: info.autor,
    //       tipo: info.tipo
    //   });
    //   this.idAAlterar=info.id;
    //   this.emInsercao=false;
    // }
  }

  insereLivro() {
    console.log(this.formLivros);
    // valid/invalid
    console.log(this.formLivros.invalid);
    console.log(this.formLivros.status);
    // if (this.formLivros.invalid===true)
    if (this.formLivros.invalid) {
      alert("Existem erros no preenchimento do formulário!")
    } else {
      if (this.emInsercao) {
        // console.log(this.formLivros.value);
        this.novoLivro.emit(this.formLivros.value);
        // this.formLivros.reset({ 
        //   titulo: "Gone", 
        //   editora: "Livros do Brasil", 
        //   ano_publicacao: 1992, 
        //   autor: "Pedro Remoaldo", 
        //   tipo: "Humor"});
      } else {
        this.livroAlterado.emit({...this.formLivros.value, id: this.idAAlterar});
      }
      this.formLivros.reset();
    }
  }

  get titulo() {
    // return this.formLivros.get("titulo")!;
    return this.formLivros.controls["titulo"]!;
  }

  cancelarAlteracao() {
    this.formLivros.reset();
    this.emInsercao=true;
  }
}

