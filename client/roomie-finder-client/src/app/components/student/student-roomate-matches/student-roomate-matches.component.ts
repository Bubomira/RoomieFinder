import { Component } from '@angular/core';
import { StudentService } from '../../../services/student/student.service';
import { ActivatedRoute, Router } from '@angular/router';
import { BestRoomateList } from '../../../models/studentModels';
import { HttpErrorResponse } from '@angular/common/http';

@Component({
  selector: 'app-student-roomate-matches',
  templateUrl: './student-roomate-matches.component.html',
})
export class StudentRoomateMatchesComponent {
   private pageNumber:number=1;
   private userId:string|null='';

   protected bestMatchesList:any;

   constructor(activatedRoute:ActivatedRoute, studentService:StudentService,router:Router) {
        activatedRoute.queryParamMap.subscribe(map=>{
           this.pageNumber=Number(map.get('pageNumber'));
           this.userId= map.get('userId');
        })

        studentService.getStudentMatches(this.pageNumber,this.userId?this.userId:'').subscribe({
          next:(bestRoomateList:BestRoomateList)=>{
             this.bestMatchesList=bestRoomateList;
             console.log(this.bestMatchesList);
          },
          error:(err:HttpErrorResponse)=>{
            alert('Unable to get matches..try again later')
          }
        })
    
   }
}
