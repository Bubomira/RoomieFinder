import {HttpClient} from '@angular/common/http';
import { Injectable } from '@angular/core';

import {JwtService} from '../jwt/jwt.service';

import {answerSheetEndpoint} from '../../utils/endpoints';
import { AnswerSheetPost, QualityPreview } from '../../models/answerSheetModels';
import { Observable } from 'rxjs';


@Injectable({
  providedIn: 'root'
})

export class AnswerSheetService {

  constructor(private http:HttpClient,private jwt:JwtService) { }

  getAllQualities=():Observable<QualityPreview[]>=>
    this.http.get<QualityPreview[]>(`${answerSheetEndpoint}/all/qualities`,{
      headers:{
        'Authorization':`Bearer ${this.jwt.getUserToken()}`
      }
    })

    submitAnswerSheet=(answerSheetPost:AnswerSheetPost)=>
      this.http.post(`${answerSheetEndpoint}/submit`,answerSheetPost,{
        headers:{
          'Authorization':`Bearer ${this.jwt.getUserToken()}`
        },
        observe:'response'
      })

}
