export interface LoginUser{
   email:string,
   password:string
}

export interface LoggedInUser{
   id:string,
   token:string,
   fullName:string,
   hasChangedPassword:boolean,
   isAdmin:boolean
}

export interface RegisterUser{
    firstName:string,
    lastName:string,
    email:string,
    username:string,
    setUpPassword:string,
    yearAtUniversity:number,
    isMale:boolean
}

export interface PasswordChange{
    email:string,
    initialPassword:string,
    newPassword:string
}