export default function NaucnoIstrazivackaInstitucija()
{
    return(
        <div className="flex">
            <div className="flex flex-col">
            Stranica Istrazivaci
           <table className=" border-4 bg-cyan-100">
                <tr>
                    <th> ID_IR</th>
                    <th> Naslov</th>
                    <th>Apstrakt</th>
                    <th>Kljucne Reci</th>
                    <th>Datum Kreiranja</th>
                    <th>Datum Objavljivanja</th>
                    <th>Status</th>
                </tr>
           </table>
            </div>

           <div class="control-panel">
            <h1 className=" font-serif font-bold text-2xl">Controls</h1>
            <button class="small-button"> Dodaj </button>
            <button class="small-button"> Izbrisi</button>
            <button class="small-button"> Promeni</button>
           </div>
        </div>
    )
}