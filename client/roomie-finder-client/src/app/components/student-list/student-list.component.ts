import { Component } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { StudentService } from '../../services/student/student.service';
import { areGraduated, genderPreference } from '../../utils/enums';
import { HttpErrorResponse } from '@angular/common/http';
import { StudentSearchList } from '../../models/studentModels';

@Component({
  selector: 'app-student-list',
  templateUrl: './student-list.component.html',
})
export class StudentListComponent {
  protected pageNumber=0;
  protected studentList:any;

   constructor(private activatedRoute:ActivatedRoute,private studentService:StudentService) {
       activatedRoute.queryParamMap.subscribe(params=>{
         this.pageNumber= Number(params.get('pageNumber')||1);
       })
       
       this.studentService.getAllStudents(this.pageNumber,'',areGraduated.doesntMatter,genderPreference.doesntMatter)
       .subscribe({
         next:(studentSearchList:StudentSearchList)=>{
            this.studentList=studentSearchList;
            console.log(studentSearchList);
         },
         error(err:HttpErrorResponse) {
           console.log(err);
         },
         
       })
       
   }

    
}
