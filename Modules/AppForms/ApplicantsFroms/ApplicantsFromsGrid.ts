import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { ApplicantsFromsColumns, ApplicantsFromsRow, ApplicantsFromsService } from '../../ServerTypes/AppForms';
import { ApplicantsFromsDialog } from './ApplicantsFromsDialog';

@Decorators.registerClass('AppForms.AppForms.ApplicantsFromsGrid')
export class ApplicantsFromsGrid extends EntityGrid<ApplicantsFromsRow, any> {
    protected getColumnsKey() { return ApplicantsFromsColumns.columnsKey; }
    protected getDialogType() { return ApplicantsFromsDialog; }
    protected getRowDefinition() { return ApplicantsFromsRow; }
    protected getService() { return ApplicantsFromsService.baseUrl; }

    constructor(container: JQuery) {
        super(container);
    }
}