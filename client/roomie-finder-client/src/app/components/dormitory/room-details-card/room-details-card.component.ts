import { Component, Input } from '@angular/core';
import { RoomDetails } from '../../../models/roomModels';
import { roomType } from '../../../utils/enums';

@Component({
  selector: 'app-room-details-card',
  templateUrl: './room-details-card.component.html',
})
export class RoomDetailsCardComponent {
   @Input() room:RoomDetails={
    id:0,
    roomNumber:0,
    remainingCapacity:0,
    roomType:roomType.single
   }

   @Input() personCount:number=0;

   protected roomTypes = roomType;
}
