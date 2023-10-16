import { StringEditor, PrefixedContext } from "@serenity-is/corelib";
import { initFormType } from "@serenity-is/corelib/q";

export interface GovernoratesForm {
    Name: StringEditor;
}

export class GovernoratesForm extends PrefixedContext {
    static formKey = 'AppForms.Governorates';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!GovernoratesForm.init)  {
            GovernoratesForm.init = true;

            var w0 = StringEditor;

            initFormType(GovernoratesForm, [
                'Name', w0
            ]);
        }
    }
}