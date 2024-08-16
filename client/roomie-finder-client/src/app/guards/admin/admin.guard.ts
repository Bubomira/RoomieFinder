import { inject } from '@angular/core';
import { CanActivateFn,Router} from '@angular/router';

import { JwtService } from '../../services/jwt/jwt.service';

export const adminGuard: CanActivateFn = (route, state) => {
  let jwt = inject(JwtService);
  let router = inject(Router);

  if(jwt.checkIfUserIsAdmin()){
    return true;
  }

  return router.navigate(['/404'])
};
