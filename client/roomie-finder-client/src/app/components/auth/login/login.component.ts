import { Component, inject } from '@angular/core';
import { FormBuilder, Validators } from '@angular/forms';

import { userConstants } from '../../../utils/constants';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
})

export class LoginComponent {
   private formBuilder = inject(FormBuilder);

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

    
   }
}
