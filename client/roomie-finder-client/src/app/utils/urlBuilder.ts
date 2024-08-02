import {buildUrl} from 'build-url-ts'

import * as endpoints from  './endpoints'
import { areGraduated, genderPreference } from './enums'

export const buildStudentListUrl=
     (pageNumber:number,search:string|null,graduated:areGraduated,gender:genderPreference)=>
      buildUrl(endpoints.studentEndpoint,{
         path:'all',
         queryParams:{
             pageNumber:pageNumber,
             searchTerm:search,
             areGraduated:graduated?graduated:areGraduated.doesntMatter,
             genderPreference:gender?gender:genderPreference.doesntMatter
         }
})

export const paginatorUrlBuilder=(pageNumber:number,link:string)=>
    buildUrl('localhost:4200',{
        path:link,
        queryParams:{
            pageNumber:pageNumber
        }
    })
