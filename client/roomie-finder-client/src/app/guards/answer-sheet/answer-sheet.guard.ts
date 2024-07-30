import { inject } from '@angular/core';
import { CanActivateFn,Router} from '@angular/router';

import { JwtService } from '../../services/jwt/jwt.service';

export const answerSheetGuard: CanActivateFn = (route, state) => {
  let jwt = inject(JwtService);
  let router = inject(Router);

  if (!jwt.checkIfStudentHasFilledOutTheAnswerSheet()){
     return true;
  }
  return router.navigate([''])
};
