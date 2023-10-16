import { initFullHeightGridPage } from '@serenity-is/corelib/q';
import { UniversitiesGrid } from './UniversitiesGrid';

export default function pageInit() {
    initFullHeightGridPage(new UniversitiesGrid($('#GridDiv')).element);
}