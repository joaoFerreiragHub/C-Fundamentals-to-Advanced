import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { AppComponent } from './app.component';
import { FontAwesomeModule } from '@fortawesome/angular-fontawesome';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { ModalModule } from 'ngx-bootstrap/modal';
import { BsDropdownModule } from 'ngx-bootstrap/dropdown';
import { CarouselModule } from 'ngx-bootstrap/carousel';
import { AppRoutingModule } from './app-routing.module';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { ProdutosComponent } from './produto/produtos.component';
import { ErroComponent } from './outros/erro/erro.component';
import { HomeComponent } from './outros/home/home.component';
import { PaginaPrincipalComponent } from './paginaPrincipal/pagina-principal.component';
import { BotoesComponent } from './Utilizadores/botoes/botoes.component';
import { AutenticarComponent } from './Utilizadores/autenticar/autenticar.component';
import { PaginaRegistosComponent } from './pagina-registos/pagina-registos.component';
import { PaginaprodutosComponent } from './paginaprodutos/paginaprodutos.component';
import { PerfilComponent } from './Utilizadores/perfil/perfil.component';
import { AuthService } from './servicos/shared/auth.service';
import { WishlistComponent } from './wishlist/wishlist.component';
import { PaginaAdministracaoComponent } from './pagina-administracao/pagina-administracao.component';
import { InfoProdutoComponent } from './info-produto/info-produto.component';
import { FavoritosComponent } from './favoritos/favoritos.component';

@NgModule({
  declarations: [
    AppComponent,
    ProdutosComponent,
    ErroComponent,
    HomeComponent,
    PaginaPrincipalComponent,
    BotoesComponent,
    AutenticarComponent,
    PaginaRegistosComponent,
    PaginaprodutosComponent,
    PerfilComponent,
    WishlistComponent,
    PaginaAdministracaoComponent,
    InfoProdutoComponent,
    FavoritosComponent,
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    ReactiveFormsModule,
    HttpClientModule,
    FontAwesomeModule,
    BrowserAnimationsModule,
    BsDropdownModule.forRoot(),
    CarouselModule.forRoot(),
    ModalModule.forRoot(),
    FormsModule,
  ],
  providers: [AuthService],
  bootstrap: [AppComponent],
  entryComponents: [
    AutenticarComponent,
    PaginaRegistosComponent,
    PerfilComponent,
  ],
})
export class AppModule {}
