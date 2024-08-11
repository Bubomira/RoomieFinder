import { Component,inject,Input } from '@angular/core';
import { Router } from '@angular/router';

import { StudentBestMatch } from '../../../../models/studentModels';
import { BestMatchMessages } from '../../../../utils/messages';
import { RoomService } from '../../../../services/room/room.service';
import { HttpErrorResponse } from '@angular/common/http';

@Component({
  selector: 'app-student-match-card',
  templateUrl: './student-match-card.component.html',
})
export class StudentMatchCardComponent {
  protected messages = BestMatchMessages;
  private roomService = inject(RoomService);
  private router = inject(Router);

   @Input() id:string|null='';

   @Input() matcherAssignedRoomId:number|null=null;
   @Input() isMale:boolean=false;

   @Input() student:StudentBestMatch={
    id:'',
    fullName:'',
    yearAtUniversity:1,
    hasAssignedRoom:false,
    roomCapacityLeft:0,
    assignedRoomId:null,
    assignedDormitoryName:'',
    assignedRoomNumber:null,
    answersAsUser:{
      isIntrovert:false,
      isMessy:false,
      likesQuietness:false,
      wakesUpEarly:false,
      goesToSleepEarly:false
    }
   };

   addStudentToRoom=(roomId:number,userId:string)=>{
     this.roomService.addStudentToRoom(roomId,userId)
     .subscribe({
      next:()=>{
        return this.router.navigate(['/'])
      },
      error:(error:HttpErrorResponse)=>{
        alert(`Could not add student ${this.student.fullName} to room`)
      }
     })
   }
}
