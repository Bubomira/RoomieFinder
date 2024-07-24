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
  hasChangedPassword:boolean;
  constructor() {
    this.isLoggedIn=false;
    this.isAdmin = false;  
    this.hasChangedPassword=false;
  afterRender({
    read:()=>{
      this.isLoggedIn = this.jwt.checkIfUserIsAuthenticated();
      this.isAdmin = this.jwt.checkIfUserIsAdmin();
      this.hasChangedPassword = this.jwt.checkIfUserHasChangedHisPassword();
    }
   })
  }
}
