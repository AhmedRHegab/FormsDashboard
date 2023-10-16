import { initFullHeightGridPage } from '@serenity-is/corelib/q';
import { FacultiesGrid } from './FacultiesGrid';

export default function pageInit() {
    initFullHeightGridPage(new FacultiesGrid($('#GridDiv')).element);
}