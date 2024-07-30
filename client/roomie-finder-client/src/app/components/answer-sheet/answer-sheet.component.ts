import { Component, inject,OnInit } from '@angular/core';
import {  FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';

import { AnswerSheetService } from '../../services/answer-sheet/answer-sheet.service';
import { JwtService } from '../../services/jwt/jwt.service';

import { QualityPreview,AnswerSheetPost } from '../../models/answerSheetModels';
import { HttpErrorResponse } from '@angular/common/http';

@Component({
  selector: 'app-answer-sheet',
  templateUrl: './answer-sheet.component.html',
})
export class AnswerSheetComponent implements OnInit {
  
  private formBuilder = inject(FormBuilder);
  private router = inject(Router);

  private answerSheetService = inject(AnswerSheetService);
  private jwtService = inject(JwtService);

  protected qualities:QualityPreview[]=[];
  protected answerSheetForm:FormGroup=this.formBuilder.group({
    bedEarly:['',[Validators.required]],
    isQuiet:['',[Validators.required]],
    wakesEarly:['',[Validators.required]],
    isMessy:['',[Validators.required]],
    isIntrovert:['',[Validators.required]],
    qualityIds:this.formBuilder.group({})
  });

  ngOnInit(): void {
    this.answerSheetService.getAllQualities().subscribe({
      next:(qualitiesDtos:QualityPreview[])=>{
         this.qualities = qualitiesDtos;
         let qualityControls = this.getQualities();
         
         this.qualities.forEach(quality=>{
         qualityControls.addControl(quality.id.toString(),this.formBuilder.control(false))
         })
      },
      error:(error:HttpErrorResponse)=>{
         this.router.navigate(['/404'])
      }
    })
  }

  onSubmit(e:Event){
    e.preventDefault();

    let qualityIds:Number[] = [];

    for (const quality of this.qualities) {
         var qualityControlValue = this.getQualities().controls[`${quality.id}`].value;
         if(qualityControlValue){
          qualityIds.push(quality.id)
         }
    }

    if(this.answerSheetForm.invalid || qualityIds.length==0){
      alert('Please, fill in all fields!')
      return;
    }
    
    let answerSheetPost:AnswerSheetPost={
       isMessy:this.c['isMessy'].value,
       isIntrovert:this.c['isIntrovert'].value,
       wakesUpEarly:this.c['wakesEarly'].value,
       likesQuietness:this.c['isQuiet'].value,
       goesToSleepEarly:this.c['bedEarly'].value,
       qualityIds:qualityIds
    }

    this.answerSheetService.submitAnswerSheet(answerSheetPost).subscribe({
      next:()=>{
        this.jwtService.changeHasFlledOutAnswerSheet();
        alert('Successfully submitted the answer sheet')
        return this.router.navigate(['/'])
      },
      error:()=>{
        alert('The answer sheet was not submitted. Try again later')
      }
    })

  }


  protected c =this.answerSheetForm.controls;

  protected getQualities(){
    return this.answerSheetForm.get('qualityIds') as FormGroup;
  }
}
