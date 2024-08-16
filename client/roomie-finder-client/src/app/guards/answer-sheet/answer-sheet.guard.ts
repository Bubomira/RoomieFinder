import { inject } from '@angular/core';
import { ActivatedRouteSnapshot, CanActivateFn,Router, RouterStateSnapshot} from '@angular/router';

import { JwtService } from '../../services/jwt/jwt.service';

export function answerSheetGuard(shouldBeFilled:boolean): CanActivateFn {
  return (ars: ActivatedRouteSnapshot, rss: RouterStateSnapshot) => {
      let jwt = inject(JwtService);
      let router = inject(Router);

      if(shouldBeFilled){
        if(jwt.checkIfStudentHasFilledOutTheAnswerSheet()){
           return true;
        }else{
          return router.navigate(['/answer-sheet'])
        }    
      }
  
      if (!jwt.checkIfStudentHasFilledOutTheAnswerSheet()){
          return true;    
        }   
        return router.navigate(['/404']); 
     } 
}