import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { GovernoratesColumns, GovernoratesRow, GovernoratesService } from '../../ServerTypes/AppForms';
import { GovernoratesDialog } from './GovernoratesDialog';

@Decorators.registerClass('AppForms.AppForms.GovernoratesGrid')
export class GovernoratesGrid extends EntityGrid<GovernoratesRow, any> {
    protected getColumnsKey() { return GovernoratesColumns.columnsKey; }
    protected getDialogType() { return GovernoratesDialog; }
    protected getRowDefinition() { return GovernoratesRow; }
    protected getService() { return GovernoratesService.baseUrl; }

    constructor(container: JQuery) {
        super(container);
    }
}