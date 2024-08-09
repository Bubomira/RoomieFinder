import { Component } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { DomritoryService } from '../../../services/dormitory/domritory.service';
import { DormitoryPreview } from '../../../models/dormitoryModels';
import { HttpErrorResponse } from '@angular/common/http';
import { RoomDetails } from '../../../models/roomModels';

@Component({
  selector: 'app-dormitory-rooms',
  templateUrl: './dormitory-rooms.component.html',
})
export class DormitoryRoomsComponent {
   protected firstUserId:string|null=null;
   protected secondUserId:string|null=null;
   protected userCount:number=1;
   protected isSearched:boolean=false;
   
   protected dormitories:DormitoryPreview[]=[];
   protected rooms:RoomDetails[]=[];

   constructor(private activatedRoute:ActivatedRoute,
    private dormitoryService:DomritoryService,
    private router:Router) {
      activatedRoute.queryParamMap.subscribe(params=>{
        this.firstUserId = params.get('firstUser');
        this.secondUserId=params.get('secondUser');
      })
      if(!this.firstUserId){
         this.router.navigate(['404'])
      }
      
      this.userCount=this.secondUserId?2:1;
      
      this.dormitoryService.getAllDormitories().subscribe({
        next:(dormitoriesList:DormitoryPreview[])=>{
            this.dormitories = dormitoriesList;
        },
        error:(error:HttpErrorResponse)=>{
           router.navigate(['404'])
        }
      })
      
    
   }

   getRoomsByDormitoryId(dormitoryId:number){
      this.isSearched=true;
      
      this.userCount==1? 
      this.dormitoryService.getAllSingleRoomsFromADormitory(dormitoryId).subscribe({
        next:(roomsList:RoomDetails[])=>{
          this.rooms = roomsList;
          console.log(roomsList);
        },
        error:(error:HttpErrorResponse)=>this.router.navigate(['404'])
      })
      :
      this.dormitoryService.getAllRoomsFromADormitory(dormitoryId).subscribe({
        next:(roomsList:RoomDetails[])=>{
          this.rooms = roomsList;
          console.log(roomsList);
        },
        error:(error:HttpErrorResponse)=>this.router.navigate(['404'])
      })
   }
}