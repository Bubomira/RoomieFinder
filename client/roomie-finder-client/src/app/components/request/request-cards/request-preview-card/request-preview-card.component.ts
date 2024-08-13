import { Component, Input } from '@angular/core';
import { RequestSearchPreview } from '../../../../models/requestModels';
import { requestStatus, requestType } from '../../../../utils/enums';

@Component({
  selector: 'app-request-preview-card',
  templateUrl: './request-preview-card.component.html',
})
export class RequestPreviewCardComponent {
   @Input() request:RequestSearchPreview={
     id:0,
     requesterEmail:'',
    requestStatus:requestStatus.doesntMatter,
    requestType:requestType.doesntMatter,
   }

   protected requestStatuses = requestStatus;
   protected requestTypes = requestType;
}
