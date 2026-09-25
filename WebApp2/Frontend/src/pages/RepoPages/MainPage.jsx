import { Outlet, Link } from "react-router";


export default function MainPage()
{
    return(
        <div className="flex flex-col">
            <Link to="/" className=" bg-blue-500 p-1 text-2xl w-50 hover:bg-blue-300"> ← Glavni Meni</Link>
            <Outlet />
        </div>
    );
}