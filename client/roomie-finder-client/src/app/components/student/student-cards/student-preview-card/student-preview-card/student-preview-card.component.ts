import { Component, Input } from '@angular/core';
import { StudentPreview } from '../../../../../models/studentModels';

@Component({
  selector: 'app-student-preview-card',
  templateUrl: './student-preview-card.component.html',
})
export class StudentPreviewCardComponent {
     @Input({required:true}) student:StudentPreview={
         id:'0',
         fullName:'test',
         yearAtUniversity:1
     };

     @Input({required:true}) fromProfile:boolean=true;

}
