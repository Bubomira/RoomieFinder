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
    this.setField('hasChangedPassword',true)
  }   

  changeHasFlledOutAnswerSheet(){
    this.setField('hasFilledOutAnswerhseet',true)
  }

   removeUser(){
    localStorage.removeItem('user');
   }
   
   private setField(fieldName:string,value:boolean){
      var user = this.getUser();
      if(user!=null){
        var parsedUser = JSON.parse(user);
        parsedUser[`${fieldName}`]=value;
        this.removeUser();
        this.saveToken(parsedUser);
      }
   }
}
