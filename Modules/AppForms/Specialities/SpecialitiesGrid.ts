import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { SpecialitiesColumns, SpecialitiesRow, SpecialitiesService } from '../../ServerTypes/AppForms';
import { SpecialitiesDialog } from './SpecialitiesDialog';

@Decorators.registerClass('AppForms.AppForms.SpecialitiesGrid')
export class SpecialitiesGrid extends EntityGrid<SpecialitiesRow, any> {
    protected getColumnsKey() { return SpecialitiesColumns.columnsKey; }
    protected getDialogType() { return SpecialitiesDialog; }
    protected getRowDefinition() { return SpecialitiesRow; }
    protected getService() { return SpecialitiesService.baseUrl; }

    constructor(container: JQuery) {
        super(container);
    }
}