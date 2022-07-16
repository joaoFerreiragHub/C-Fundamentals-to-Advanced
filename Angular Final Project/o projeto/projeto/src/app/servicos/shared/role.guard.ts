import { Injectable } from '@angular/core';
import {
  ActivatedRouteSnapshot,
  CanActivate,
  RouterStateSnapshot,
  UrlTree,
} from '@angular/router';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root',
})
export class RoleGuard implements CanActivate {
  canActivate() {
    let role = sessionStorage.getItem('userType');
    if (role === 'admin') {
      return true;
    }
    if (role === 'cliente') {
      return true;
    }
    alert('Não tem permissões');
    return true;
  }
}
