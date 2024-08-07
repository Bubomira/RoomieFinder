import { areGraduated, genderPreference } from "../utils/enums"
import { AnswerSheetMetadata } from "./answerSheetModels"
import { RequestPreview } from "./requestModels"
import { RoomDetails } from "./roomModels"

export interface StudentPreview{
    id:string,
    fullName:string,
    yearAtUniversity:number
}

export interface BaseStudentList{
    pageNumber:number,
    totalCount:number
}

export interface StudentList extends BaseStudentList{
    students:StudentPreview[],
}

export interface StudentSearchList extends StudentList{
    searchTerm:string | null,
    areGraduated:areGraduated,
    genderPreference:genderPreference
}

export interface BestRoomateList extends BaseStudentList{
    isMale:boolean,
    bestMatches:StudentBestMatch[]
}

export interface StudentBestMatch extends Roomate{
    AnswersAsUser:AnswerSheetMetadata,
    hasAssignedRoom:boolean,
    assignedRoomId:number|null,
    assignedRoomNumber:number|null,
    assignedDormitoryName:string|null,
    roomCapacityLeft:number|null,
    qualities:string[]
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