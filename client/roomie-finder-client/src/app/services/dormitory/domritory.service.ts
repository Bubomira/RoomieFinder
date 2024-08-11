import { Injectable } from '@angular/core';

import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

import { JwtService } from '../jwt/jwt.service';
import { dormitoryEndpoint } from '../../utils/endpoints';
import { DormitoryPreview } from '../../models/dormitoryModels';
import { RoomDetails } from '../../models/roomModels';

@Injectable({
  providedIn: 'root'
})
export class DomritoryService {

  constructor(private http:HttpClient,private jwt:JwtService) { }

  getAllDormitories=():Observable<DormitoryPreview[]>=>
    this.http.get<DormitoryPreview[]>(`${dormitoryEndpoint}/all`,{
      headers:{
        'Authorization':`Bearer ${this.jwt.getUserToken()}`
      }
    })

   getAllRoomsFromADormitory=(dormitoryId:number,isMale:boolean):Observable<RoomDetails[]>=>
    this.http.get<RoomDetails[]>(`${dormitoryEndpoint}/${dormitoryId}/rooms?isMale=${isMale}`,{
      headers:{
         'Authorization':`Bearer ${this.jwt.getUserToken()}`
      }
    })

    getAllSingleRoomsFromADormitory=(dormitoryId:number):Observable<RoomDetails[]>=>
    this.http.get<RoomDetails[]>(`${dormitoryEndpoint}/${dormitoryId}/rooms/single`,{
      headers:{
         'Authorization':`Bearer ${this.jwt.getUserToken()}`
      }
    })
}
