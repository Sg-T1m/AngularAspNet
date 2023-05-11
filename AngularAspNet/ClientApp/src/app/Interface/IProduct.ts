import { Component } from "@angular/core"
import { IComponentsType } from "./IComponentsType"
import { IManufacturer } from "./IManufacturer"
export interface IProduct {
     Id :number,
     ComponentsTypeId: number,
     ManufacturersId: number,
     Name? :string,
     Price? :string,
     CompatibilitiesId? :number
     Capacity? :string,
     Type? :string,
     Weight? :string,
     Img? :string
     Socket?:string,
     ReleaseYear? :number,
     TotalNumberOfCores? :number,
     CpubaseFrequency? :string,
     VideoMemorySize?:number
     MemoryType? : string
     NumberOfMemorySlots? :number,
     PowerDissipation? :number,
     HeatPipesDiameter? : number,
     NumberOfFansIncluded?: number,
     PowerMominal?: number,
     Collor?: string
     AllMemory?: number,
     VolumeOfOneMemoryModule? : number,
     NumberOfModulesIncluded? : number,
     ClockFrequency?: string,

    // public virtual ICollection<Compatibility> Compatibilities { get; set; } = new List<Compatibility>();
    Manufacturers?: IManufacturer
    ComponentsType?:IComponentsType
}
