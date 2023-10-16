import { Decorators, EntityDialog } from '@serenity-is/corelib';
import { UniversitiesForm, UniversitiesRow, UniversitiesService } from '../../ServerTypes/AppForms';

@Decorators.registerClass('AppForms.AppForms.UniversitiesDialog')
export class UniversitiesDialog extends EntityDialog<UniversitiesRow, any> {
    protected getFormKey() { return UniversitiesForm.formKey; }
    protected getRowDefinition() { return UniversitiesRow; }
    protected getService() { return UniversitiesService.baseUrl; }

    protected form = new UniversitiesForm(this.idPrefix);
}