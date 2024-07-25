import { Component,inject,OnInit } from '@angular/core';
import { AuthenticationService } from '../../../services/authentication/authentication.service';

import { Router } from '@angular/router';
import { JwtService } from '../../../services/jwt/jwt.service';

@Component({
  selector: 'app-logout',
  template:''
})
export class LogoutComponent implements OnInit {
   private authService = inject(AuthenticationService);
   private jwt = inject(JwtService);
   private router = inject(Router);
 
   ngOnInit(){
     this.authService.logoutAsync();
     this.jwt.removeUser();
     return this.router.navigateByUrl('/')
   }

}
