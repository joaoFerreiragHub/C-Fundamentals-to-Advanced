import { AuthService } from './auth.service';
import { Injectable } from '@angular/core';
import {
  ActivatedRouteSnapshot,
  CanActivate,
  Router,
  RouterStateSnapshot,
  UrlTree,
} from '@angular/router';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root',
})
export class AuthGuard implements CanActivate {
  constructor(private router: Router, private auth: AuthService) {}
  // canActivate(
  //   route: ActivatedRouteSnapshot,
  //   state: RouterStateSnapshot
  // ):
  //   | Observable<boolean | UrlTree>
  //   | Promise<boolean | UrlTree>
  //   | boolean
  //   | UrlTree {
  //   return this.estaAutorizado(route);
  // }

  canActivate() {
    if (this.auth.estaLogin()) {
      return true;
    }
    alert('You have not logged in');
    this.router.navigate(['/autenticar']);
    return false;
  }

  // estaAutorizado(route: ActivatedRouteSnapshot): boolean {
  //   const roles = ['admin', 'cliente'];
  //   const expectedRoles = route.data['expectedRoles'];
  //   const roleMatches = roles.findIndex(
  //     (role) => expectedRoles.indexOf(role) !== -1
  //   );
  //   return roleMatches >= 0 ? true : false;
  // }
}
