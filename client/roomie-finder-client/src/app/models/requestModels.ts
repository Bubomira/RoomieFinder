import { requestStatus, requestType } from "../utils/enums";

export interface RequestPreview{
    id:number,
    requestType:requestType,
    requestStatus:requestStatus
} 

export interface RequestSearchPreview extends RequestPreview{
    requesterEmail:string
}

export interface RequestPostDto{
    comment:string|null,
    requestType:requestType|null
}

export interface RequestSearchList{
    requests:RequestSearchPreview[],
    currentPage:number,
    prefferedRequestType:requestType,
    prefferedRequestStatus:requestStatus,
    totalCount:number
}

export interface RequestDetails extends RequestSearchPreview{
  requesterId:string,
  requesterFullNme:string,
  canBeAccepted:boolean,
}