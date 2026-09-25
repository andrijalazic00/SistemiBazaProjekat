import TableHeader from "../../components/TableHeader.jsx"
import EntityBrowser from "../../components/EntityBrowser.jsx"
import { publikacijaType} from "../../config/entities.js";

export default function Publikacija()
{
    return(
        <EntityBrowser
            types={[publikacijaType]}
            TableHeader={ <TableHeader HeaderName={"Publikacije"} previous={"naucno_istrazivacka_institucija"} next={"istrazivaci"}/>}
        />
    );
}