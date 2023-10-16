import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { FacultiesColumns, FacultiesRow, FacultiesService } from '../../ServerTypes/AppForms';
import { FacultiesDialog } from './FacultiesDialog';

@Decorators.registerClass('AppForms.AppForms.FacultiesGrid')
export class FacultiesGrid extends EntityGrid<FacultiesRow, any> {
    protected getColumnsKey() { return FacultiesColumns.columnsKey; }
    protected getDialogType() { return FacultiesDialog; }
    protected getRowDefinition() { return FacultiesRow; }
    protected getService() { return FacultiesService.baseUrl; }

    constructor(container: JQuery) {
        super(container);
    }
}