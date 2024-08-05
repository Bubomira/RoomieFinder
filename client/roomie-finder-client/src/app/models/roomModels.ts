import { roomType } from "../utils/enums";

export interface RoomDetails{
    id:number,
    roomNumber:number,
    roomType:roomType,
    remainingCapacity:number
}