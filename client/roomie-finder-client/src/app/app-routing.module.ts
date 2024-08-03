import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

import { authGuard } from './guards/auth/auth.guard';
import { guestGuard } from './guards/guest/guest.guard';
import { changePasswordGuard } from './guards/change-password/change-password.guard';
import { answerSheetGuard } from './guards/answer-sheet/answer-sheet.guard';
import { studentGuard } from './guards/student/student.guard';
import { adminGuard } from './guards/admin/admin.guard';

import { LoginComponent } from './components/auth/login/login.component';
import { ChangePasswordComponent } from './components/auth/change-password/change-password.component';
import { LogoutComponent } from './components/auth/logout/logout.component';
import { RegisterStudentComponent } from './components/auth/register-student/register-student.component';
import { AnswerSheetComponent } from './components/answer-sheet/answer-sheet.component';
import { StudentListComponent } from './components/student-list/student-list.component';
import { StudentProfileComponent } from './components/student-profile/student-profile.component';

const routes: Routes = [
     {path:'login', component:LoginComponent,canActivate:[guestGuard]},
     {path:'logout',component:LogoutComponent,canActivate:[authGuard]},
     {path:'change-password',component:ChangePasswordComponent,canActivate:[authGuard,changePasswordGuard,studentGuard]},
     {path:'register-student',component:RegisterStudentComponent,canActivate:[authGuard,adminGuard]},
     {path:'answer-sheet',component:AnswerSheetComponent,canActivate:[authGuard,answerSheetGuard,studentGuard]},
     {path:'student-list',component:StudentListComponent, canActivate:[authGuard,adminGuard]},
     {path:'student/:id',component:StudentProfileComponent,canActivate:[authGuard]}
];

@NgModule({
    imports:[RouterModule.forRoot(routes)],
    exports:[RouterModule]
})

export class AppRoutingModule { }