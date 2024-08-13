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
import { StudentListComponent } from './components/student/student-list/student-list.component';
import { StudentProfileComponent } from './components/student/student-profile/student-profile.component';
import { StudentsWithoutRoomComponent } from './components/student/students-without-room/students-without-room.component';
import { StudentRoomateMatchesComponent } from './components/student/student-roomate-matches/student-roomate-matches.component';
import { DormitoryRoomsComponent } from './components/dormitory/dormitory-rooms/dormitory-rooms.component';
import { RequestSubmitComponent } from './components/request/request-submit/request-submit.component';
import { RequestListComponent } from './components/request/request-list/request-list.component';

const routes: Routes = [
     {path:'login', component:LoginComponent,canActivate:[guestGuard]},
     {path:'logout',component:LogoutComponent,canActivate:[authGuard]},
     {path:'change-password',component:ChangePasswordComponent,canActivate:[authGuard,changePasswordGuard,studentGuard]},
     {path:'register-student',component:RegisterStudentComponent,canActivate:[authGuard,adminGuard]},

     {path:'answer-sheet',component:AnswerSheetComponent,canActivate:[authGuard,answerSheetGuard,studentGuard]},

     {path:'student-list',component:StudentListComponent, canActivate:[authGuard,adminGuard]},
     {path:'student/:id',component:StudentProfileComponent,canActivate:[authGuard]},
     {path:'students-without-room',component:StudentsWithoutRoomComponent,canActivate:[authGuard,adminGuard]},
     {path:'find-matches',component:StudentRoomateMatchesComponent,canActivate:[authGuard,adminGuard]},

     {path:'match-in-a-room',component:DormitoryRoomsComponent,canActivate:[authGuard,adminGuard]},

     {path:'request-submit',component:RequestSubmitComponent,canActivate:[authGuard,studentGuard]},
     {path:'request-list',component:RequestListComponent,canActivate:[authGuard,adminGuard]}
];

@NgModule({
    imports:[RouterModule.forRoot(routes)],
    exports:[RouterModule]
})

export class AppRoutingModule { }