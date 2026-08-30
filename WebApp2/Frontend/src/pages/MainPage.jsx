import { NavLink, Outlet, Link } from "react-router";

export default function MainPage()
{
    return(
        <div className="flex flex-col">
            <div className=" flex space-x-5">
                <NavLink to="istrazivac" className="text-2xl font-mono font-bold text-blue-950 hover:text-blue-400"> Istrazivac</NavLink>
                <NavLink to="istrazivackirezultat" className="text-2xl font-mono font-bold text-blue-950  hover:text-blue-400"> Istrazivacki Rezultat </NavLink>
                <NavLink to="naucnoistrazivackainstitucija" className="text-2xl font-mono font-bold text-blue-950  hover:text-blue-400">Naucno Istrazivacka Institucija </NavLink>
            </div>
            <Outlet />
            <Link to="/" className=' font-mono font-bold text-2xl bg-blue-600 border-4 p-3 rounded-3xl hover:bg-linear-to-b from-blue-600 to-emerald-200  text-center'> Nazad </Link>
        </div>
    )
}