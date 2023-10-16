import { initFullHeightGridPage } from '@serenity-is/corelib/q';
import { GovernoratesGrid } from './GovernoratesGrid';

export default function pageInit() {
    initFullHeightGridPage(new GovernoratesGrid($('#GridDiv')).element);
}