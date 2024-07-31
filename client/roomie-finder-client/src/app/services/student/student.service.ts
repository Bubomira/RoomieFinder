import { Injectable } from '@angular/core';
import {HttpClient} from '@angular/common/http'
import { Observable } from 'rxjs';
import { StudentSearchList } from '../../models/studentModels';

import { studentEndpoint } from '../../utils/endpoints';

import { buildStudentListUrl } from '../../utils/urlBuilder';
import { areGraduated, genderPreference } from '../../utils/enums';

import { JwtService } from '../jwt/jwt.service';

@Injectable({
  providedIn: 'root'
})
export class StudentService {

    constructor(private http:HttpClient,private jwt:JwtService) { }

     getAllStudents(pageNumber:number,searchTerm:string|null,graduated:areGraduated,gender:genderPreference)
     :Observable<StudentSearchList>
     {
       let studentUrl = buildStudentListUrl(pageNumber,searchTerm,graduated,gender);
       return this.http.get<StudentSearchList>(studentUrl?studentUrl:`${studentEndpoint}/all?pageNumber=1`,{
         headers:{
           'Authorization':`Bearer ${this.jwt.getUserToken()}`
         }
       })
     }
}
