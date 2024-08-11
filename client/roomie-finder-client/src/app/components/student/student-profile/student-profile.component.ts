import { Component } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { StudentProfile } from '../../../models/studentModels';
import { StudentService } from '../../../services/student/student.service';
import { HttpErrorResponse } from '@angular/common/http';
import { JwtService } from '../../../services/jwt/jwt.service';

import { roomType } from '../../../utils/enums';

@Component({
  selector: 'app-student-profile',
  templateUrl: './student-profile.component.html',
})
export class StudentProfileComponent {
  private id:string|null='';
  protected student:any={};
  protected isAdmin:boolean=false;
  protected roomTypes = roomType;

  constructor(private activatedRoute:ActivatedRoute,
    private studentSevice:StudentService,
    private jwtService:JwtService,
    private router:Router) 
    {
      activatedRoute.paramMap.subscribe(param=>{
       this.id= param.get('id')

       this.studentSevice.getStudentProfile(this.id?this.id:'').subscribe({
        next:(studentProfile:StudentProfile)=>{
          this.student=studentProfile;
          this.isAdmin=this.jwtService.checkIfUserIsAdmin();
          console.log(this.student)
        },
        error:(error:HttpErrorResponse)=>{
           this.router.navigate(['404'])
        }     
      })   
    })     
  }
}
