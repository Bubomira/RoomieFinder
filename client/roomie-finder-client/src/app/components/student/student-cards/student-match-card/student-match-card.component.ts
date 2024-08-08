import { Component,Input } from '@angular/core';
import { StudentBestMatch } from '../../../../models/studentModels';
import { BestMatchMessages } from '../../../../utils/messages';

@Component({
  selector: 'app-student-match-card',
  templateUrl: './student-match-card.component.html',
})
export class StudentMatchCardComponent {
  protected messages = BestMatchMessages;

   @Input() id:string|null='';

   @Input() student:StudentBestMatch={
    id:'',
    fullName:'',
    yearAtUniversity:1,
    hasAssignedRoom:false,
    roomCapacityLeft:0,
    assignedRoomId:null,
    assignedDormitoryName:'',
    assignedRoomNumber:null,
    qualities:[],
    answersAsUser:{
      isIntrovert:false,
      isMessy:false,
      likesQuietness:false,
      wakesUpEarly:false,
      goesToSleepEarly:false
    }
   };

}
