import { Decorators, EntityDialog } from '@serenity-is/corelib';
import { SpecialitiesForm, SpecialitiesRow, SpecialitiesService } from '../../ServerTypes/AppForms';

@Decorators.registerClass('AppForms.AppForms.SpecialitiesDialog')
export class SpecialitiesDialog extends EntityDialog<SpecialitiesRow, any> {
    protected getFormKey() { return SpecialitiesForm.formKey; }
    protected getRowDefinition() { return SpecialitiesRow; }
    protected getService() { return SpecialitiesService.baseUrl; }

    protected form = new SpecialitiesForm(this.idPrefix);
}