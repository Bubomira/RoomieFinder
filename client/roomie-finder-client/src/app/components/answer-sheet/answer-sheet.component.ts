import { Component, inject } from '@angular/core';

import { FormBuilder } from '@angular/forms';

@Component({
  selector: 'app-answer-sheet',
  templateUrl: './answer-sheet.component.html',
})
export class AnswerSheetComponent {
  private formBuilder = inject(FormBuilder);

  answerSheetRadio = this.formBuilder.group({
     bedEarly:[true],
     isQuiet:[true],
     wakesEarly:[true],
     isMessy:[true],
     isIntrivert:[true]
  })


  protected c =this.answerSheetRadio.controls;
}
