import { fieldsProxy } from "@serenity-is/corelib/q";

export interface ApplicantsFromsRow {
    Id?: number;
    GovernorateId?: number;
    FacultyId?: number;
    UniversityId?: number;
    NameEn?: string;
    Mobile?: string;
    GithubLink?: string;
    LinkedInLink?: string;
    ItiGraduate?: boolean;
    YearOfGraduation?: string;
    GraduationYear?: string;
    CurrentCompany?: string;
    CurrentSalary?: string;
    ExpectedSalary?: string;
    AvailabilityDate?: string;
    InterestedWorkingInCairo?: boolean;
    MobileAppsExperience?: boolean;
    ECommerceAppsExperience?: boolean;
    Cv?: string;
    SpecialityId?: number;
    GovernorateName?: string;
    FacultyName?: string;
    UniversityName?: string;
    SpecialityName?: string;
}

export abstract class ApplicantsFromsRow {
    static readonly idProperty = 'Id';
    static readonly nameProperty = 'NameEn';
    static readonly localTextPrefix = 'AppForms.ApplicantsFroms';
    static readonly deletePermission = 'ApplicantsFroms';
    static readonly insertPermission = 'ApplicantsFroms';
    static readonly readPermission = 'ApplicantsFroms';
    static readonly updatePermission = 'ApplicantsFroms';

    static readonly Fields = fieldsProxy<ApplicantsFromsRow>();
}