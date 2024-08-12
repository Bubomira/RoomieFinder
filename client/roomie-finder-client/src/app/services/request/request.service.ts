import { Observable } from 'rxjs';
import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

import { requestType } from '../../utils/enums';
import { JwtService } from '../jwt/jwt.service';
import { requestEndpoint } from '../../utils/endpoints';

@Injectable({
  providedIn: 'root'
})
export class RequestService {

  constructor(private http:HttpClient,private jwt:JwtService) { }

  getPossibleRequestForStudent=():Observable<requestType[]>=>
    this.http.get<requestType[]>(`${requestEndpoint}/possible/types`,{
      headers:{
        'Authorization':`Bearer ${this.jwt.getUserToken()}`
      }
    })
}
