import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { LoggedInUser, LoginUser } from '../../models/userModels';
import { Observable } from 'rxjs';

import { authenticationEndpoint } from '../../utils/endpoints';


@Injectable({
  providedIn: 'root'
})
export class AuthenticationService {

  constructor(private http: HttpClient) { }

  loginUserAsync(user:LoginUser):Observable<LoggedInUser>{
    return this.http.post<LoggedInUser>(`${authenticationEndpoint}/login`,user);
  }
}
