import { Injectable } from '@angular/core';
import { LoggedInUser } from '../../models/userModels';

@Injectable({
  providedIn: 'root'
})
export class JwtService {

  saveToken(user:LoggedInUser){
    localStorage.setItem('user',JSON.stringify(user))
  }

  getUser(){
    return localStorage.getItem('user');
  }

  getUserToken(){
    var user = this.getUser();
    if(user){
      return JSON.parse(user).token;
    }
  }

  checkIfUserIsAuthenticated(){
    var user= this.getUser();
    return user!=null;
  }

  checkIfUserIsAdmin(){
    var user= this.getUser();
    return user? JSON.parse(user).isAdmin:false;
  }

  checkIfUserHasChangedHisPassword(){
    var user= this.getUser();
    return user? JSON.parse(user).hasChangedPassword:false;
  }

  checkIfStudentHasFilledOutTheAnswerSheet(){
    var user= this.getUser();
    return user? JSON.parse(user).hasFilledOutAnswerhseet :false;
  }

  changeHasSetPassword(){
    var user = this.getUser();
    if(user!=null){
      var parsedUser = JSON.parse(user);
      parsedUser.hasChangedPassword=true;
      this.removeUser();
      this.saveToken(parsedUser);
    }
  }

   removeUser(){
    localStorage.removeItem('user');
   }
  
  constructor() { }
}
