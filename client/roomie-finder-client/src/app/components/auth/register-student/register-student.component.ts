import { Component,inject } from '@angular/core';
import { Router } from '@angular/router';
import { FormBuilder, Validators } from '@angular/forms';

import { AuthenticationService } from '../../../services/authentication/authentication.service';
import { RegisterUser } from '../../../models/userModels';

import { userConstants,studentConstants } from '../../../utils/constants';
import { HttpErrorResponse } from '@angular/common/http';

@Component({
  selector: 'app-register-student',
  templateUrl: './register-student.component.html',
})
export class RegisterStudentComponent {
  private formBuilder = inject(FormBuilder);
  private authService = inject(AuthenticationService)
  private router = inject(Router);

  registerForm = this.formBuilder.group({
    firstName:['',[Validators.required,
      Validators.maxLength(userConstants.firstNameMaxLength),
      Validators.minLength(userConstants.firstNameMinLength)
    ]],
    lastName:['',[Validators.required,
      Validators.maxLength(userConstants.lastNameMaxLength),
      Validators.minLength(userConstants.lastNameMinLength)
    ]],
    email:['',[Validators.required,
      Validators.email
    ]],
    username:['',[Validators.required,
      Validators.maxLength(userConstants.usernameMaxLength),
      Validators.minLength(userConstants.usernameMinLength)
    ]],
    setUpPassword:['',[Validators.required,
      Validators.maxLength(userConstants.passwordMaxLength),
      Validators.minLength(userConstants.passwordMinLength),
      Validators.pattern('([a-z][0-9])+|([0-9][a-z])+'),
    ]],
    yearAtUniversity:[1,[Validators.required,
      Validators.max(studentConstants.maxYearAtUniversity),
      Validators.min(studentConstants.minYearAtUniversity)
    ]],
    isMale:['true',[Validators.required]]
  })

  onSubmit(e:Event){
    e.preventDefault();

    if(this.registerForm.invalid){
      return;
    }

    
    let user:RegisterUser={
    firstName:this.c.firstName.value? this.c.firstName.value:'',
    lastName:this.c.lastName.value? this.c.lastName.value:'',
    email:this.c.email.value? this.c.email.value:'',
    username:this.c.username.value? this.c.username.value:'',
    setUpPassword:this.c.setUpPassword.value? this.c.setUpPassword.value:'',
    yearAtUniversity:this.c.yearAtUniversity.value? this.c.yearAtUniversity.value:1,
    isMale:this.c.isMale.value=='true'?true:false
   }
   
   this.authService.registerUser(user).subscribe({
    next:(message:string)=>{
      alert(message);
      return this.router.navigate(['/'])
    },
    error:(error:HttpErrorResponse)=>alert('Unsuccessful registration')
   })

  }


  protected c = this.registerForm.controls;
}
