import { fieldsProxy } from "@serenity-is/corelib/q";

export interface SpecialitiesRow {
    Id?: number;
    Name?: string;
}

export abstract class SpecialitiesRow {
    static readonly idProperty = 'Id';
    static readonly nameProperty = 'Name';
    static readonly localTextPrefix = 'AppForms.Specialities';
    static readonly deletePermission = 'Specialities';
    static readonly insertPermission = 'Specialities';
    static readonly readPermission = 'Specialities';
    static readonly updatePermission = 'Specialities';

    static readonly Fields = fieldsProxy<SpecialitiesRow>();
}