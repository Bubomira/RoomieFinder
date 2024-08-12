import { AbstractControl ,Validators } from "@angular/forms";
import { requestType } from "../utils/enums";

export function commentConditionalRequiredField(formControl:AbstractControl){
    if(!formControl.parent){
        return;
    }
        
    if(formControl.parent?.get('requestType')?.value==requestType.specificRoomate){
       formControl.setValidators([Validators.email,Validators.required])
       return;
    }

    return  formControl.clearValidators()
}