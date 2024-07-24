import { Component,inject } from '@angular/core';

import { FormBuilder, Validators } from '@angular/forms';

import { userConstants } from '../../../utils/constants';

@Component({
  selector: 'app-change-password',
  templateUrl: './change-password.component.html',
})
export class ChangePasswordComponent {
  private formBuilder = inject(FormBuilder);

  changePasswordForm = this.formBuilder.group({
    email:['',[Validators.required,
      Validators.email]],
    initialPassword:['',[Validators.required,
      Validators.maxLength(userConstants.passwordMaxLength),
      Validators.minLength(userConstants.passwordMinLength)
    ]],
    newPassword:['',[Validators.required,
      Validators.maxLength(userConstants.passwordMaxLength),
      Validators.minLength(userConstants.passwordMinLength)
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


  }

  protected c= this.changePasswordForm.controls;
}
