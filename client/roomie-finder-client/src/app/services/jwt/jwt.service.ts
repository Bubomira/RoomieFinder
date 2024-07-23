import { Injectable } from '@angular/core';
import { LoggedInUser } from '../../models/userModels';

@Injectable({
  providedIn: 'root'
})
export class JwtService {

  saveToken(user:LoggedInUser){
    localStorage.setItem('user',JSON.stringify(user))
  }
  
  constructor() { }
}
