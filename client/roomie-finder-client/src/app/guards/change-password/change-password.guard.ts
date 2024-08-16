import { inject } from '@angular/core';
import { ActivatedRouteSnapshot, CanActivateFn,Router, RouterStateSnapshot } from '@angular/router';

import { JwtService } from '../../services/jwt/jwt.service';

export const changePasswordGuard=(shouldBeChanged:boolean): CanActivateFn=> {
  return (ars: ActivatedRouteSnapshot, rss: RouterStateSnapshot) => {
  let jwt = inject(JwtService);
  let router = inject(Router);

   if(!shouldBeChanged ){   
    if(!jwt.checkIfUserHasChangedHisPassword()){
      return true;
    }else{
      return router.navigate(['/404']);
    }
   }

    if(jwt.checkIfUserHasChangedHisPassword()){
         return true;
    }else{
      return router.navigate(['/change-password']);
    }
  }
}