import { PaginaAdministracaoComponent } from './pagina-administracao/pagina-administracao.component';
import { BotoesComponent } from './Utilizadores/botoes/botoes.component';
import { WishlistComponent } from './wishlist/wishlist.component';
import { RoleGuard } from './servicos/shared/role.guard';
import { AuthGuard } from './servicos/shared/auth.guard';
import { PaginaRegistosComponent } from './pagina-registos/pagina-registos.component';
import { PaginaPrincipalComponent } from './paginaPrincipal/pagina-principal.component';
import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { ErroComponent } from './outros/erro/erro.component';
import { HomeComponent } from './outros/home/home.component';
import { AutenticarComponent } from './Utilizadores/autenticar/autenticar.component';
import { ProdutosComponent } from './produto/produtos.component';
import { PaginaprodutosComponent } from './paginaprodutos/paginaprodutos.component';
import { PerfilComponent } from './Utilizadores/perfil/perfil.component';
import { from } from 'rxjs';

const routes: Routes = [
  { path: '', component: PaginaPrincipalComponent },
  { path: 'produtos', component: ProdutosComponent },
  { path: 'produtos/:id', component: ProdutosComponent },
  {
    path: 'paginaProdutos/:peca/:opcoes',
    component: PaginaprodutosComponent,
  },
  { path: 'perfil/:id', component: PerfilComponent },
  { path: 'home', component: PaginaPrincipalComponent },
  { path: 'registar', component: PaginaRegistosComponent },
  { path: 'autenticar', component: AutenticarComponent },
  {
    path: 'perfil',
    component: PerfilComponent,
    // canActivate: [AuthGuard, RoleGuard],
  },
  {
    path: 'wishlist',
    component: WishlistComponent,
    // canActivate: [AuthGuard, RoleGuard],
  },
  { path: 'botoes', component: BotoesComponent },
  {
    path: 'admin',
    component: PaginaAdministracaoComponent,
  },
  { path: '**', component: ErroComponent },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule],
})
export class AppRoutingModule {}
