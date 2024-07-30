import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

import { authGuard } from './guards/auth/auth.guard';
import { guestGuard } from './guards/guest/guest.guard';
import { changePasswordGuard } from './guards/change-password/change-password.guard';
import { answerSheetGuard } from './guards/answer-sheet/answer-sheet.guard';

import { LoginComponent } from './components/auth/login/login.component';
import { ChangePasswordComponent } from './components/auth/change-password/change-password.component';
import { LogoutComponent } from './components/auth/logout/logout.component';
import { RegisterStudentComponent } from './components/auth/register-student/register-student.component';
import { AnswerSheetComponent } from './components/answer-sheet/answer-sheet.component';

const routes: Routes = [
     {path:'login', component:LoginComponent,canActivate:[guestGuard]},
     {path:'logout',component:LogoutComponent,canActivate:[authGuard]},
     {path:'change-password',component:ChangePasswordComponent,canActivate:[authGuard,changePasswordGuard]},
     {path:'register-student',component:RegisterStudentComponent,canActivate:[authGuard]},
     {path:'answer-sheet',component:AnswerSheetComponent,canActivate:[authGuard,answerSheetGuard]}
];

@NgModule({
    imports:[RouterModule.forRoot(routes)],
    exports:[RouterModule]
})

export class AppRoutingModule { }