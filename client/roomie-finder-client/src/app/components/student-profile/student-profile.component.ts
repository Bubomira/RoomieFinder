import { Component } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { StudentProfile } from '../../models/studentModels';
import { StudentService } from '../../services/student/student.service';
import { HttpErrorResponse } from '@angular/common/http';

@Component({
  selector: 'app-student-profile',
  templateUrl: './student-profile.component.html',
})
export class StudentProfileComponent {
  private id:string|null='';
  protected student:any={};

  constructor(private activatedRoute:ActivatedRoute,
    private studentSevice:StudentService,
    private router:Router) 
    {
      activatedRoute.paramMap.subscribe(param=>{
       this.id= param.get('id')

       this.studentSevice.getStudentProfile(this.id?this.id:'').subscribe({
        next:(studentProfile:StudentProfile)=>{
          this.student=studentProfile;
        },
        error:(error:HttpErrorResponse)=>{
           this.router.navigate(['404'])
        }     
      })   
    })     
  }
}
