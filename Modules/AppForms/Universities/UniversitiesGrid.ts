import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { UniversitiesColumns, UniversitiesRow, UniversitiesService } from '../../ServerTypes/AppForms';
import { UniversitiesDialog } from './UniversitiesDialog';

@Decorators.registerClass('AppForms.AppForms.UniversitiesGrid')
export class UniversitiesGrid extends EntityGrid<UniversitiesRow, any> {
    protected getColumnsKey() { return UniversitiesColumns.columnsKey; }
    protected getDialogType() { return UniversitiesDialog; }
    protected getRowDefinition() { return UniversitiesRow; }
    protected getService() { return UniversitiesService.baseUrl; }

    constructor(container: JQuery) {
        super(container);
    }
}