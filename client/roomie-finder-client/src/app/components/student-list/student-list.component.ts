import { Component, inject } from '@angular/core';
import { FormBuilder } from '@angular/forms';
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
  protected studentService = inject(StudentService);

  protected areGraduated = areGraduated;
  protected genderPreference = genderPreference;

  protected studentList:any;
  protected isSearched = false;

  protected searchForm = this.formBuilder.group({
    graduated:[areGraduated.doesntMatter],
    searchTerm:[''],
    gender:[genderPreference.doesntMatter]
  })

   onSubmit(e:Event){
      e.preventDefault();
      this.isSearched = true;
      this.getStudents(1);
   }

   onLink=(e:Event,pageNumber:number)=>{
     e.preventDefault();
     this.getStudents(pageNumber);
   }
   
   protected c =this.searchForm.controls;

   private getStudents=(pageNumber:number)=>{
    this.studentService.getAllStudents(pageNumber,this.c.searchTerm.value? this.c.searchTerm.value:'',
      this.c.graduated.value? this.c.graduated.value:areGraduated.doesntMatter,
      this.c.gender.value?this.c.gender.value:genderPreference.doesntMatter)
      .subscribe({
        next:(studentSearchList:StudentSearchList)=>{
           this.studentList=studentSearchList;
        },
        error(err:HttpErrorResponse) {
          console.log(err);
        },
        
      })   
   }
  
}
