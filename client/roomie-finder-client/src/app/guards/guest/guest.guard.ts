import { inject } from '@angular/core';
import { CanActivateFn,Router } from '@angular/router';

import { JwtService } from '../../services/jwt/jwt.service';

export const guestGuard: CanActivateFn = (route, state) => {
  let jwt = inject(JwtService);
  let router = inject(Router);

  if(!jwt.checkIfUserIsAuthenticated()){
    return true;
  }

  return router.navigateByUrl('/')
};
