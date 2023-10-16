import { StringEditor, PrefixedContext } from "@serenity-is/corelib";
import { initFormType } from "@serenity-is/corelib/q";

export interface SpecialitiesForm {
    Name: StringEditor;
}

export class SpecialitiesForm extends PrefixedContext {
    static formKey = 'AppForms.Specialities';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!SpecialitiesForm.init)  {
            SpecialitiesForm.init = true;

            var w0 = StringEditor;

            initFormType(SpecialitiesForm, [
                'Name', w0
            ]);
        }
    }
}