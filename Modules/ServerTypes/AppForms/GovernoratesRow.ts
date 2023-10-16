import { fieldsProxy } from "@serenity-is/corelib/q";

export interface GovernoratesRow {
    Id?: number;
    Name?: string;
}

export abstract class GovernoratesRow {
    static readonly idProperty = 'Id';
    static readonly nameProperty = 'Name';
    static readonly localTextPrefix = 'AppForms.Governorates';
    static readonly deletePermission = 'Governorates';
    static readonly insertPermission = 'Governorates';
    static readonly readPermission = 'Governorates';
    static readonly updatePermission = 'Governorates';

    static readonly Fields = fieldsProxy<GovernoratesRow>();
}