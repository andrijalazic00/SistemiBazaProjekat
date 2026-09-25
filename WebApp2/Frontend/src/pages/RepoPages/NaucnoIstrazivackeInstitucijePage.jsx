import TableHeader from "../../components/TableHeader.jsx"
import EntityBrowser from "../../components/EntityBrowser.jsx"
import { institucijaType} from "../../config/entities.js";


export default function Naucno_Istrazivacka_Institucija()
{
    return(
        <EntityBrowser
            types={[institucijaType]}
            TableHeader={ <TableHeader HeaderName={"Naucno Istrazivacke Institucije"} previous={"istrazivacki_rezultati"} next={"publikacija"}/>}
        />
    );
}