import { Component, inject } from '@angular/core';
import { FormBuilder, Validators } from '@angular/forms';

import { userConstants } from '../../../utils/constants';
import { AuthenticationService } from '../../../services/authentication/authentication.service';
import { LoggedInUser, LoginUser } from '../../../models/userModels';
import { JwtService } from '../../../services/jwt/jwt.service';

import { Router } from '@angular/router';
import { HttpErrorResponse } from '@angular/common/http';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
})

export class LoginComponent {
   private formBuilder = inject(FormBuilder);
   private authService = inject(AuthenticationService);
   private jwtService = inject(JwtService);
   private router = inject(Router);

    loginForm = this.formBuilder.group({
      email:['',[Validators.required,
        Validators.email]],
      password:['',[Validators.required,
        Validators.maxLength(userConstants.passwordMaxLength),
        Validators.minLength(userConstants.passwordMinLength)]]
    })

   protected c = this.loginForm.controls;
    
   onSubmit = (e:Event)=>{
     e.preventDefault();
    
     if(this.loginForm.invalid){
        return;
     }

     let user:LoginUser = {
      email:this.c.email.value?this.c.email.value:'',
      password:this.c.password.value?this.c.password.value:''
     }

     this.authService.loginUserAsync(user).subscribe({
      next:(user:LoggedInUser)=>{
         this.jwtService.saveToken(user);
         if(!user.hasChangedPassword){
          this.router.navigate(['/change-password'])
         }
         this.router.navigate(['/']);
      },
      error:(error:HttpErrorResponse)=>{
        //  this.router.navigate(['/']);
      }      
     })   
   }
}
