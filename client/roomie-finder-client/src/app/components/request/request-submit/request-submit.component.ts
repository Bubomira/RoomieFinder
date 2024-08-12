import { HttpErrorResponse } from '@angular/common/http';
import { Component,inject } from '@angular/core';
import { FormBuilder, Validators } from '@angular/forms';
import { Router } from '@angular/router';

import { requestType } from '../../../utils/enums';
import { RequestService } from '../../../services/request/request.service';
import { commentConditionalRequiredField } from '../../../validators/commentCustomValidator';

@Component({
  selector: 'app-request-submit',
  templateUrl: './request-submit.component.html',
})
export class RequestSubmitComponent {
  protected requestTypes= requestType;
  protected canRequest:boolean=true;
  protected possibleRequestTypes:requestType[]=[];

  private formBuilder = inject(FormBuilder);

  protected requestForm = this.formBuilder.group({
    comment:[''],
    requestType:[requestType,[Validators.required]]
  })

  constructor(private requestService:RequestService,private router:Router) {
     this.requestService.getPossibleRequestForStudent().subscribe({
      next:(requestTypesList:requestType[])=>{
        if(requestTypesList.length==0){
          this.canRequest=false;
        }
        this.possibleRequestTypes = requestTypesList;
        this.c.requestType.valueChanges.subscribe(()=>{
          commentConditionalRequiredField(this.c.comment)
          this.c.comment.updateValueAndValidity();
        })
      },
      error:(error:HttpErrorResponse)=>{
        return router.navigate(['/404'])
      }
     })
    
  }



  onSubmit(e:Event){
     e.preventDefault();
     console.log(this.requestForm);
  }

  protected c = this.requestForm.controls;

}
