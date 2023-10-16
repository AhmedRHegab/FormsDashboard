import { Decorators, EntityDialog } from '@serenity-is/corelib';
import { GovernoratesForm, GovernoratesRow, GovernoratesService } from '../../ServerTypes/AppForms';

@Decorators.registerClass('AppForms.AppForms.GovernoratesDialog')
export class GovernoratesDialog extends EntityDialog<GovernoratesRow, any> {
    protected getFormKey() { return GovernoratesForm.formKey; }
    protected getRowDefinition() { return GovernoratesRow; }
    protected getService() { return GovernoratesService.baseUrl; }

    protected form = new GovernoratesForm(this.idPrefix);
}