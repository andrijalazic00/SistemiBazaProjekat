import TableHeader from "../../components/TableHeader.jsx"
import EntityBrowser from "../../components/EntityBrowser.jsx"
import { istrazivackiRezultatTypes} from "../../config/entities.js";

export default function Istrazivacki_rezultati()
{
    return(
        <EntityBrowser
            types={istrazivackiRezultatTypes}
            TableHeader={ <TableHeader HeaderName={"Istrazivacki Rezultati"} previous={"istrazivaci"} next={"naucno_istrazivacka_institucija"}/>}
        />
    );
}