import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { CardsComponent } from './cards/cards/cards.component';
import { GestaolivrosComponent } from './child/gestaolivros/gestaolivros.component';
import { InfolivroComponent } from './child/infolivro/infolivro.component';
import { PostsComponent } from './jsonplaceholder/posts/posts.component';
import { ErroComponent } from './outros/erro/erro.component';
import { HomeComponent } from './outros/home/home.component';
import { TesteComponent } from './testes/teste/teste.component';
import { TestedadosComponent } from './testes/testedados/testedados.component';

const routes: Routes = [
  { path: '', component: HomeComponent },
  { path: 'testes', component: TesteComponent },
  { path: 'testesdados', component: TestedadosComponent },
  { path: 'cards', component: CardsComponent },
  { path: 'child', component: GestaolivrosComponent },
  { path: 'child/:id', component: InfolivroComponent },
  { path: 'posts', component: PostsComponent },
  { path: '**', component: ErroComponent }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
