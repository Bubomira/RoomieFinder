import { Component, OnInit } from '@angular/core';
import { HttpErrorResponse } from '@angular/common/http';
import { ActivatedRoute, Router } from '@angular/router';

import { RequestService } from '../../../services/request/request.service';
import { RequestDetails } from '../../../models/requestModels';

import { requestType,requestStatus } from '../../../utils/enums';
import { JwtService } from '../../../services/jwt/jwt.service';

@Component({
  selector: 'app-request-details',
  templateUrl: './request-details.component.html',
})
export class RequestDetailsComponent implements OnInit {
   protected request:any;
   protected requestId:number=0;
   protected isAdmin:boolean=false;

   protected requestTypes=requestType;
   protected requestStatuses=requestStatus

 constructor(private activatedRoute:ActivatedRoute,
  private requestService:RequestService,
  private JwtService:JwtService,
  private router:Router) {
     this.activatedRoute.paramMap.subscribe(paramMap=>{
       this.requestId=Number(paramMap.get('id'));       
     })
     this.isAdmin = this.JwtService.checkIfUserIsAdmin();
 }
  ngOnInit(): void {
    this.requestService.getRequestDetails(this.requestId).subscribe({
      next:(requestDetails:RequestDetails)=>{
        this.request = requestDetails;
        console.log(this.request);
      },
      error:(error:HttpErrorResponse)=>{
        return this.router.navigate(['/404'])
      }
    })
  }

  onRemove=()=>
    this.requestService.removeRequest(this.request.id).subscribe({
      next:()=>this.router.navigate(['/student',this.request.requesterUserId]),
      error:(err:HttpErrorResponse)=>alert('Could not remove request, try again later')
    })
   
}