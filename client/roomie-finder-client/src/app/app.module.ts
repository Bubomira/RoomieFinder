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
import { StudentListComponent } from './components/student-list/student-list.component';


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