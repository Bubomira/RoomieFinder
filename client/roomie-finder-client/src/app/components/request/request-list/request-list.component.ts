import { Component, inject } from '@angular/core';

import { FormBuilder } from '@angular/forms';
import { requestStatus, requestType } from '../../../utils/enums';

@Component({
  selector: 'app-request-list',
  templateUrl: './request-list.component.html',
})
export class RequestListComponent {
   private formBuilder = inject(FormBuilder);

   protected requestTypes=requestType;
   protected requestStatuses = requestStatus;

   protected requestSearchForm = this.formBuilder.group({
    requestType:[requestType.doesntMatter],
    requestStatus:[requestStatus.doesntMatter]
   })

   onSubmit(e:Event){
     e.preventDefault();
   }


   protected c=this.requestSearchForm.controls;
}
