import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

import { JwtService } from '../jwt/jwt.service';
import { roomEndpoint } from '../../utils/endpoints';

@Injectable({
  providedIn: 'root'
})
export class RoomService {
  
  constructor(private http:HttpClient,private jwt:JwtService) { }

  addStudentToRoom=(roomId:number,userId:string)=>
    this.http.get(`${roomEndpoint}/${roomId}/add/student/${userId}`,{
      headers:{
        'Authorization':`Bearer ${this.jwt.getUserToken()}`
      }
    })

    addStudentToRoomByEmail=(roomId:number,email:string)=>
      this.http.get(`${roomEndpoint}/${roomId}/add/student/by/email/${email}`,{
        headers:{
           'Authorization':`Bearer ${this.jwt.getUserToken()}`
        }
      })

    removeStudentFromRoom=(roomId:number,userId:string)=>
      this.http.get(`${roomEndpoint}/${roomId}/remove/student/${userId}`,{
        headers:{
          'Authorization':`Bearer ${this.jwt.getUserToken()}`
        }
      })
}
