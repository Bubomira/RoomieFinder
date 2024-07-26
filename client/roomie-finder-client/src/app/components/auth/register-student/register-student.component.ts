import { Component,inject } from '@angular/core';
import { Router } from '@angular/router';
import { FormBuilder,Validator, Validators } from '@angular/forms';

import { AuthenticationService } from '../../../services/authentication/authentication.service';

import { userConstants,studentConstants } from '../../../utils/constants';

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
      Validators.minLength(userConstants.passwordMinLength)
    ]],
    yearAtUniversity:[1,[Validators.required,
      Validators.max(studentConstants.maxYearAtUniversity),
      Validators.min(studentConstants.minYearAtUniversity)
    ]],
    isMale:[true,[Validators.required]]
  })



  protected c = this.registerForm.controls;
}
