import TableHeader from "../../components/TableHeader.jsx"
import EntityBrowser from "../../components/EntityBrowser.jsx"
import { istrazivacTypes } from "../../config/entities.js";

export default function Istrazivaci()
{
    return(
        <EntityBrowser
            types={istrazivacTypes}
            TableHeader={ <TableHeader HeaderName={"Istrazivac"} previous={"publikacija"} next={"istrazivacki_rezultati"}/>}
        />
    );
}