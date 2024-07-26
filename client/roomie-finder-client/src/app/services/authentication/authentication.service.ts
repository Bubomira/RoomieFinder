import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { LoggedInUser, LoginUser,PasswordChange, RegisterUser} from '../../models/userModels';
import { Observable } from 'rxjs';

import { authenticationEndpoint } from '../../utils/endpoints';
import { JwtService } from '../jwt/jwt.service';


@Injectable({
  providedIn: 'root'
})
export class AuthenticationService {

  constructor(private http: HttpClient,private jwt:JwtService) { }

  loginUserAsync(user:LoginUser):Observable<LoggedInUser>{
    return this.http.post<LoggedInUser>(`${authenticationEndpoint}/login`,user);
  }

  registerUser(user:RegisterUser){
    return this.http.post(`${authenticationEndpoint}/register`,user,{
      headers:{
        'Authorization':`Bearer ${this.jwt.getUserToken()}`
     },
     responseType:'text'
    })
  }

  logoutAsync(){
   return this.http.get(`${authenticationEndpoint}/logout`,{
      headers:{
         'Authorization':`Bearer ${this.jwt.getUserToken()}`
      },
      observe:'response'
    })
  }

  changePasswordAsync(user:PasswordChange){
    return this.http.post(`${authenticationEndpoint}/password/change`,user,{
      headers:{
        'Authorization':`Bearer ${this.jwt.getUserToken()}`
      },
      responseType:'text'
    });
  }
}
