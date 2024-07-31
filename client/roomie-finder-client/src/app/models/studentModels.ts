import { areGraduated, genderPreference } from "../utils/enums"

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