import { StringEditor, PrefixedContext } from "@serenity-is/corelib";
import { initFormType } from "@serenity-is/corelib/q";

export interface FacultiesForm {
    Name: StringEditor;
}

export class FacultiesForm extends PrefixedContext {
    static formKey = 'AppForms.Faculties';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!FacultiesForm.init)  {
            FacultiesForm.init = true;

            var w0 = StringEditor;

            initFormType(FacultiesForm, [
                'Name', w0
            ]);
        }
    }
}