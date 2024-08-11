import { Component, Input } from '@angular/core';
import { Roomate } from '../../../../models/studentModels';

@Component({
  selector: 'app-roomate-card',
  templateUrl: './roomate-card.component.html',
})
export class RoomateCardComponent {
    @Input() roomate:Roomate={
      id:'',
      fullName:'',
      yearAtUniversity:0
    }

    @Input() isAdmin:boolean=false;
  
}
