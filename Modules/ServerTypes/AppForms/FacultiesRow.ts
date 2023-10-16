import { fieldsProxy } from "@serenity-is/corelib/q";

export interface FacultiesRow {
    Id?: number;
    Name?: string;
}

export abstract class FacultiesRow {
    static readonly idProperty = 'Id';
    static readonly nameProperty = 'Name';
    static readonly localTextPrefix = 'AppForms.Faculties';
    static readonly deletePermission = 'Faculties';
    static readonly insertPermission = 'Faculties';
    static readonly readPermission = 'Faculties';
    static readonly updatePermission = 'Faculties';

    static readonly Fields = fieldsProxy<FacultiesRow>();
}