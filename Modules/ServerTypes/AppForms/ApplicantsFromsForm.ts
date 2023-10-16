import { IntegerEditor, StringEditor, BooleanEditor, DateEditor, PrefixedContext } from "@serenity-is/corelib";
import { initFormType } from "@serenity-is/corelib/q";

export interface ApplicantsFromsForm {
    GovernorateId: IntegerEditor;
    FacultyId: IntegerEditor;
    UniversityId: IntegerEditor;
    NameEn: StringEditor;
    Mobile: StringEditor;
    GithubLink: StringEditor;
    LinkedInLink: StringEditor;
    ItiGraduate: BooleanEditor;
    YearOfGraduation: StringEditor;
    GraduationYear: StringEditor;
    CurrentCompany: StringEditor;
    CurrentSalary: StringEditor;
    ExpectedSalary: StringEditor;
    AvailabilityDate: DateEditor;
    InterestedWorkingInCairo: BooleanEditor;
    MobileAppsExperience: BooleanEditor;
    ECommerceAppsExperience: BooleanEditor;
    Cv: StringEditor;
    SpecialityId: IntegerEditor;
}

export class ApplicantsFromsForm extends PrefixedContext {
    static formKey = 'AppForms.ApplicantsFroms';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!ApplicantsFromsForm.init)  {
            ApplicantsFromsForm.init = true;

            var w0 = IntegerEditor;
            var w1 = StringEditor;
            var w2 = BooleanEditor;
            var w3 = DateEditor;

            initFormType(ApplicantsFromsForm, [
                'GovernorateId', w0,
                'FacultyId', w0,
                'UniversityId', w0,
                'NameEn', w1,
                'Mobile', w1,
                'GithubLink', w1,
                'LinkedInLink', w1,
                'ItiGraduate', w2,
                'YearOfGraduation', w1,
                'GraduationYear', w1,
                'CurrentCompany', w1,
                'CurrentSalary', w1,
                'ExpectedSalary', w1,
                'AvailabilityDate', w3,
                'InterestedWorkingInCairo', w2,
                'MobileAppsExperience', w2,
                'ECommerceAppsExperience', w2,
                'Cv', w1,
                'SpecialityId', w0
            ]);
        }
    }
}