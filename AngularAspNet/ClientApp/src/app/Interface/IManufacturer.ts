import { IProduct } from "./IProduct"

export interface IManufacturer {
     Id : number,
     Name? : String
     Components : IProduct
}
