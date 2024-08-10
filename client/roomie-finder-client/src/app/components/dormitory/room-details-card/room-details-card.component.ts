import { Component, inject, Input } from '@angular/core';
import { RoomDetails } from '../../../models/roomModels';
import { roomType } from '../../../utils/enums';
import { RoomService } from '../../../services/room/room.service';
import { HttpErrorResponse } from '@angular/common/http';
import { Router } from '@angular/router';

@Component({
  selector: 'app-room-details-card',
  templateUrl: './room-details-card.component.html',
})
export class RoomDetailsCardComponent {
   protected roomTypes = roomType;
   protected router = inject(Router);
   protected roomService = inject(RoomService);

   @Input() room:RoomDetails={
    id:0,
    roomNumber:0,
    remainingCapacity:0,
    roomType:roomType.single
   }

   @Input() userIds:any[]=[];

   @Input() personCount:number=0;


   assignToRoom=()=>{
     let isSuccessful:boolean=true;
     
     this.userIds.forEach(id=>{
       if(id){
         this.roomService.addStudentToRoom(this.room.id,id).subscribe({
           error:(error:HttpErrorResponse)=>{
             isSuccessful=false;
           }
         })
       }
      return isSuccessful? this.router.navigate(['/']):this.router.navigate(['404'])
     })
   }
}
