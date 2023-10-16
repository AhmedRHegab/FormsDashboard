import { fieldsProxy } from "@serenity-is/corelib/q";

export interface UniversitiesRow {
    Id?: number;
    Name?: string;
}

export abstract class UniversitiesRow {
    static readonly idProperty = 'Id';
    static readonly nameProperty = 'Name';
    static readonly localTextPrefix = 'AppForms.Universities';
    static readonly deletePermission = 'Universities';
    static readonly insertPermission = 'Universities';
    static readonly readPermission = 'Universities';
    static readonly updatePermission = 'Universities';

    static readonly Fields = fieldsProxy<UniversitiesRow>();
}