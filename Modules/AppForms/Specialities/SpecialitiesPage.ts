import { initFullHeightGridPage } from '@serenity-is/corelib/q';
import { SpecialitiesGrid } from './SpecialitiesGrid';

export default function pageInit() {
    initFullHeightGridPage(new SpecialitiesGrid($('#GridDiv')).element);
}