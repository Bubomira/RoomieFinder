import { BrowserModule } from '@angular/platform-browser';
import {ReactiveFormsModule} from '@angular/forms';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';

import { AppComponent } from './app.component';
import { LoginComponent } from './components/auth/login/login.component';
import { provideHttpClient } from '@angular/common/http';
import { NavigationComponent } from './components/navigation/navigation.component';
import { ChangePasswordComponent } from './components/auth/change-password/change-password.component';
import { LogoutComponent } from './components/auth/logout/logout.component';
import { RegisterStudentComponent } from './components/auth/register-student/register-student.component';
import { AnswerSheetComponent } from './components/answer-sheet/answer-sheet.component';
import { StudentListComponent } from './components/student/student-list/student-list.component';
import { StudentPreviewCardComponent } from './components/student/student-cards/student-preview-card/student-preview-card/student-preview-card.component';
import { StudentProfileComponent } from './components/student/student-profile/student-profile.component';
import { StudentsWithoutRoomComponent } from './components/student/students-without-room/students-without-room.component';


@NgModule({
  declarations: [
    AppComponent,
    LoginComponent,
    NavigationComponent,
    ChangePasswordComponent,
    LogoutComponent,
    RegisterStudentComponent,
    AnswerSheetComponent,
    StudentListComponent,
    StudentPreviewCardComponent,
    StudentProfileComponent,
    StudentsWithoutRoomComponent,
],
    imports: [
    BrowserModule,
    AppRoutingModule,
    ReactiveFormsModule,
  ],
  providers: [provideHttpClient()],
  bootstrap: [AppComponent]
})
export class AppModule { }