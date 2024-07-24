import { Component,inject,afterRender } from '@angular/core';
import { JwtService } from '../../services/jwt/jwt.service';

@Component({
  selector: 'app-navigation',
  templateUrl: './navigation.component.html'
})

export class NavigationComponent {
 protected jwt = inject(JwtService);
  isLoggedIn:boolean;
  isAdmin:boolean;
  constructor() {
    this.isLoggedIn=false;
    this.isAdmin = false;  

  afterRender({
    read:()=>{
      this.isLoggedIn = this.jwt.checkIfUserIsAuthenticated();
      this.isAdmin = this.jwt.checkIfUserIsAdmin();
    }
   })
  }
}
