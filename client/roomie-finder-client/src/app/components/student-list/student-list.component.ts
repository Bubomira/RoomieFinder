import { Component, inject } from '@angular/core';
import { FormBuilder } from '@angular/forms';
import { ActivatedRoute } from '@angular/router';
import { HttpErrorResponse } from '@angular/common/http';

import { StudentService } from '../../services/student/student.service';
import { areGraduated, genderPreference } from '../../utils/enums';
import { StudentSearchList } from '../../models/studentModels';

@Component({
  selector: 'app-student-list',
  templateUrl: './student-list.component.html',
})
export class StudentListComponent {
  private formBuilder = inject(FormBuilder);
  protected areGraduated = areGraduated;
  protected genderPreference = genderPreference;
  protected pageNumber=0;
  protected studentList:any;

  protected searchForm = this.formBuilder.group({
    graduated:[areGraduated.doesntMatter],
    searchTerm:[''],
    gender:[genderPreference.doesntMatter]
  })

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

   onSubmit(e:Event){
      e.preventDefault();
      console.log(this.searchForm)
   }

    
}
