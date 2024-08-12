import { requestStatus, requestType } from "../utils/enums";

export interface RequestPreview{
    id:number,
    requestType:requestType,
    requestStatus:requestStatus
} 

export interface RequestPostDto{
    comment:string|null,
    requestType:requestType|null
}