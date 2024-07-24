import { Component,inject } from '@angular/core';
import { Router } from '@angular/router';

import { FormBuilder, Validators } from '@angular/forms';

import { userConstants } from '../../../utils/constants';
import { PasswordChange } from '../../../models/userModels';
import { AuthenticationService } from '../../../services/authentication/authentication.service';
import { HttpErrorResponse } from '@angular/common/http';
import { JwtService } from '../../../services/jwt/jwt.service';

@Component({
  selector: 'app-change-password',
  templateUrl: './change-password.component.html',
})
export class ChangePasswordComponent {
  private formBuilder = inject(FormBuilder);
  private authService = inject(AuthenticationService);
  private jwtService = inject(JwtService)
  private router = inject(Router);
  

  changePasswordForm = this.formBuilder.group({
    email:['',[Validators.required,
      Validators.email]],
    initialPassword:['',[Validators.required,
      Validators.maxLength(userConstants.passwordMaxLength),
      Validators.minLength(userConstants.passwordMinLength)
    ]],
    newPassword:['',[Validators.required,
      Validators.maxLength(userConstants.passwordMaxLength),
      Validators.minLength(userConstants.passwordMinLength),
      Validators.pattern('([a-z][0-9])+|([0-9][a-z])+'),
    ]],
    repeatPassword:[''],
  })

   onSubmit(e:Event){
      e.preventDefault();

      if(this.changePasswordForm.invalid){
        return;
      }
      else if(this.c.newPassword.value!=this.c.repeatPassword.value){
        alert('Passwords must match!');
        return;
      }
      let user : PasswordChange= {
        email:this.c.email.value?this.c.email.value:'',
        initialPassword:this.c.initialPassword.value? this.c.initialPassword.value:'',
        newPassword:this.c.newPassword.value?this.c.newPassword.value:''
      }
      this.authService.changePasswordAsync(user).subscribe({
        next:(res:string)=>{
          this.jwtService.changeHasSetPassword();
          return this.router.navigateByUrl('/');
        },
        error:(error:HttpErrorResponse)=>{
          console.log(error)
          alert(error.message);
        }
      })

  }

  protected c= this.changePasswordForm.controls;
}
