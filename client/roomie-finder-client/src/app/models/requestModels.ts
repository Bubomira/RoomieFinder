import { requestStatus, requestType } from "../utils/enums";

export interface RequestPreview{
    id:number,
    requestType:requestType,
    requestStatus:requestStatus
} 