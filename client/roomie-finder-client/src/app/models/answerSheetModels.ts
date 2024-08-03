export interface QualityPreview{
    id:Number,
    name:string
}

export interface AnswerSheetPost extends AnswerSheetMetadata{
    qualityIds:Number[]
}

export interface AnswerSheetMetadata{
    isMessy:boolean,
    isIntrovert:boolean,
    goesToSleepEarly:boolean,
    likesQuietness:boolean,
    wakesUpEarly:boolean
}