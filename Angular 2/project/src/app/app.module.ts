import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { AppRoutingModule } from './app-routing.module';
import { ReactiveFormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';

import { AppComponent } from './app.component';
import { TesteComponent } from './testes/teste/teste.component';
import { TestedadosComponent } from './testes/testedados/testedados.component';
import { GestaolivrosComponent } from './child/gestaolivros/gestaolivros.component';
import { FormpesquisaComponent } from './child/formpesquisa/formpesquisa.component';
import { TabeladadosComponent } from './child/tabeladados/tabeladados.component';
import { CardsComponent } from './cards/cards/cards.component';
import { CardComponent } from './cards/card/card.component';
import { InsereLivrosComponent } from './child/insere-livros/insere-livros.component';
import { ErroComponent } from './outros/erro/erro.component';
import { HomeComponent } from './outros/home/home.component';
import { InfolivroComponent } from './child/infolivro/infolivro.component';
import { PostsComponent } from './jsonplaceholder/posts/posts.component';

@NgModule({
  declarations: [
    AppComponent,
    TesteComponent,
    TestedadosComponent,
    GestaolivrosComponent,
    FormpesquisaComponent,
    TabeladadosComponent,
    CardsComponent,
    CardComponent,
    InsereLivrosComponent,
    ErroComponent,
    HomeComponent,
    InfolivroComponent,
    PostsComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    ReactiveFormsModule,
    HttpClientModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
