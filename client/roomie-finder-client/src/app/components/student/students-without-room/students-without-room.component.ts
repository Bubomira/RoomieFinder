import { Component } from '@angular/core';
import { HttpErrorResponse } from '@angular/common/http';
import { ActivatedRoute, Router } from '@angular/router';

import { StudentService } from '../../../services/student/student.service';
import { StudentList } from '../../../models/studentModels';

@Component({
  selector: 'app-students-without-room',
  templateUrl: './students-without-room.component.html',
})
export class StudentsWithoutRoomComponent {
  protected pageNumber=1;
  protected studentList:any;

  constructor(activatedRoute:ActivatedRoute,studentService:StudentService,router:Router) {
    activatedRoute.queryParamMap.subscribe(map=>{
      this.pageNumber=Number(map.get('pageNumber'))
      
      studentService.getAllStudentsWithoutARoom(this.pageNumber).subscribe({
        next:(studentList:StudentList)=>{
           this.studentList=studentList;
           console.log(studentList);
        },
        error:(error:HttpErrorResponse)=>{
           router.navigate(['404']);
        }
      })
    })
    
  }
}
