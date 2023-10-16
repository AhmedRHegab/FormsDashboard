import { Decorators, EntityDialog } from '@serenity-is/corelib';
import { ApplicantsFromsForm, ApplicantsFromsRow, ApplicantsFromsService } from '../../ServerTypes/AppForms';

@Decorators.registerClass('AppForms.AppForms.ApplicantsFromsDialog')
export class ApplicantsFromsDialog extends EntityDialog<ApplicantsFromsRow, any> {
    protected getFormKey() { return ApplicantsFromsForm.formKey; }
    protected getRowDefinition() { return ApplicantsFromsRow; }
    protected getService() { return ApplicantsFromsService.baseUrl; }

    protected form = new ApplicantsFromsForm(this.idPrefix);
}