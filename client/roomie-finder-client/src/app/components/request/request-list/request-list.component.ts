import { HttpErrorResponse } from '@angular/common/http';
import { Component, inject } from '@angular/core';
import { FormBuilder } from '@angular/forms';
import { Router } from '@angular/router';

import { requestStatus, requestType } from '../../../utils/enums';
import { RequestSearchList } from '../../../models/requestModels';
import { RequestService } from '../../../services/request/request.service';

@Component({
  selector: 'app-request-list',
  templateUrl: './request-list.component.html',
})
export class RequestListComponent {
   private formBuilder = inject(FormBuilder);
   private requestService = inject(RequestService);
   private router = inject(Router);

   protected requestTypes=requestType;
   protected requestStatuses = requestStatus;
   protected requestSearchList:any;
   protected isSearched=false;

   protected requestSearchForm = this.formBuilder.group({
    requestType:[requestType.doesntMatter],
    requestStatus:[requestStatus.doesntMatter]
   })

   onSubmit(e:Event){
     e.preventDefault();
     this.isSearched=true;
     this.getData(1);     
   }

   onLink(e:Event,pageNumber:number){
     e.preventDefault();
     this.getData(pageNumber);
   }


   getData=(pageNumber:number)=>{
      this.requestService.getRequestList(pageNumber,
      this.c.requestType.value?this.c.requestType.value:this.requestTypes.doesntMatter,
      this.c.requestStatus.value?this.c.requestStatus.value:this.requestStatuses.doesntMatter).subscribe({
        next:(requestList:RequestSearchList)=>{
          this.requestSearchList = requestList;
          console.log(this.requestSearchList);
        },
        error:(error:HttpErrorResponse)=>{
          this.router.navigate(['/404'])
        }
      })
   }

   protected c=this.requestSearchForm.controls;
}
