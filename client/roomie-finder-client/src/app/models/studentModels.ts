import { areGraduated, genderPreference } from "../utils/enums"
import { AnswerSheetMetadata } from "./answerSheetModels"
import { RequestPreview } from "./requestModels"
import { RoomDetails } from "./roomModels"

export interface StudentPreview{
    id:string,
    fullName:string,
    yearAtUniversity:number
}

export interface StudentSearchList{
    pageNumber:number,
    totalCount:number,
    students:StudentPreview[],
    searchTerm:string | null,
    areGraduated:areGraduated,
    genderPreference:genderPreference
}

export interface Roomate{
    id:string,
    fullName:string,
    yearAtUniversity:number,
}

export interface StudentProfile{
    id:string,
    fullName:string,
    userName:string,
    email:string,
    yearAtUniversity:number,
    isMale:boolean,
    generalAnswers:AnswerSheetMetadata,
    room:RoomDetails,
    roomates:Roomate[],
    requests:RequestPreview[]
}