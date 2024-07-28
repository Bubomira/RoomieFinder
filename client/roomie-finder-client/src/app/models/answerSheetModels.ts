export interface QualityPreview{
    id:Number,
    name:string
}

export interface AnswerSheetPost{
    isMessy:boolean,
    isIntrovert:boolean,
    goesToSleepEarly:boolean,
    likesQuietness:boolean,
    wakesUpEarly:boolean,
    qualityIds:Number[]
}