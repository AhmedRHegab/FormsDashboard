import { initFullHeightGridPage } from '@serenity-is/corelib/q';
import { ApplicantsFromsGrid } from './ApplicantsFromsGrid';

export default function pageInit() {
    initFullHeightGridPage(new ApplicantsFromsGrid($('#GridDiv')).element);
}