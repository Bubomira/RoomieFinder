import { Component,inject } from '@angular/core';
import { JwtService } from '../../services/jwt/jwt.service';

@Component({
  selector: 'app-navigation',
  templateUrl: './navigation.component.html'
})

export class NavigationComponent {
 protected jwt = inject(JwtService);
  isLoggedIn:boolean;
  isAdmin:boolean;
  userId:string;
  hasChangedPassword:boolean;
  constructor() {
    this.isLoggedIn=false;
    this.isAdmin = false;
    this.hasChangedPassword=false;
    this.userId='';
  }

  ngDoCheck(){
    this.isLoggedIn = this.jwt.checkIfUserIsAuthenticated();
    this.isAdmin = this.jwt.checkIfUserIsAdmin();
    this.hasChangedPassword = this.jwt.checkIfUserHasChangedHisPassword();
    this.userId=this.jwt.getUserId();
  }
}
