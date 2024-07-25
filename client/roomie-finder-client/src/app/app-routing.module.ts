import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

import { LoginComponent } from './components/auth/login/login.component';
import { ChangePasswordComponent } from './components/auth/change-password/change-password.component';
import { LogoutComponent } from './components/auth/logout/logout.component';

const routes: Routes = [
     {path:'login', component:LoginComponent},
     {path:'change-password',component:ChangePasswordComponent},
     {path:'logout',component:LogoutComponent}
];

@NgModule({
    imports:[RouterModule.forRoot(routes)],
    exports:[RouterModule]
})

export class AppRoutingModule { }