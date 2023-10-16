import { SaveRequest, SaveResponse, ServiceOptions, DeleteRequest, DeleteResponse, RetrieveRequest, RetrieveResponse, ListRequest, ListResponse, serviceRequest } from "@serenity-is/corelib/q";
import { ApplicantsFromsRow } from "./ApplicantsFromsRow";

export namespace ApplicantsFromsService {
    export const baseUrl = 'AppForms/ApplicantsFroms';

    export declare function Create(request: SaveRequest<ApplicantsFromsRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): JQueryXHR;
    export declare function Update(request: SaveRequest<ApplicantsFromsRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): JQueryXHR;
    export declare function Delete(request: DeleteRequest, onSuccess?: (response: DeleteResponse) => void, opt?: ServiceOptions<any>): JQueryXHR;
    export declare function Retrieve(request: RetrieveRequest, onSuccess?: (response: RetrieveResponse<ApplicantsFromsRow>) => void, opt?: ServiceOptions<any>): JQueryXHR;
    export declare function List(request: ListRequest, onSuccess?: (response: ListResponse<ApplicantsFromsRow>) => void, opt?: ServiceOptions<any>): JQueryXHR;

    export const Methods = {
        Create: "AppForms/ApplicantsFroms/Create",
        Update: "AppForms/ApplicantsFroms/Update",
        Delete: "AppForms/ApplicantsFroms/Delete",
        Retrieve: "AppForms/ApplicantsFroms/Retrieve",
        List: "AppForms/ApplicantsFroms/List"
    } as const;

    [
        'Create', 
        'Update', 
        'Delete', 
        'Retrieve', 
        'List'
    ].forEach(x => {
        (<any>ApplicantsFromsService)[x] = function (r, s, o) {
            return serviceRequest(baseUrl + '/' + x, r, s, o);
        };
    });
}