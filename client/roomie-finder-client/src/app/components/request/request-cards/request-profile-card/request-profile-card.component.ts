import { Component,Input } from '@angular/core';
import { RequestPreview } from '../../../../models/requestModels';
import { requestStatus, requestType } from '../../../../utils/enums';

@Component({
  selector: 'app-request-profile-card',
  templateUrl: './request-profile-card.component.html',

})
export class RequestProfileCardComponent {
    @Input() request:RequestPreview={
      id:0,
      requestStatus:requestStatus.doesntMatter,
      requestType:requestType.doesntMatter
    }

    protected requestTypes = requestType;
    protected requestStatus=requestStatus;
}
