import { Decorators, EntityDialog } from '@serenity-is/corelib';
import { FacultiesForm, FacultiesRow, FacultiesService } from '../../ServerTypes/AppForms';

@Decorators.registerClass('AppForms.AppForms.FacultiesDialog')
export class FacultiesDialog extends EntityDialog<FacultiesRow, any> {
    protected getFormKey() { return FacultiesForm.formKey; }
    protected getRowDefinition() { return FacultiesRow; }
    protected getService() { return FacultiesService.baseUrl; }

    protected form = new FacultiesForm(this.idPrefix);
}