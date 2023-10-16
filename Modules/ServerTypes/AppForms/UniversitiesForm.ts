import { StringEditor, PrefixedContext } from "@serenity-is/corelib";
import { initFormType } from "@serenity-is/corelib/q";

export interface UniversitiesForm {
    Name: StringEditor;
}

export class UniversitiesForm extends PrefixedContext {
    static formKey = 'AppForms.Universities';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!UniversitiesForm.init)  {
            UniversitiesForm.init = true;

            var w0 = StringEditor;

            initFormType(UniversitiesForm, [
                'Name', w0
            ]);
        }
    }
}