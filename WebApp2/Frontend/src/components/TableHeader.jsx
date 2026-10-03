import { Link } from "react-router";
export default function TableHeader({HeaderName, previous, next})
{

    next = "../" + next;
    previous = "../" + previous;
    
    return(
            <div className=" flex flex-row">
            <Link to={previous} className="change-page-button">&lt;</Link>
            <h1 className=" table-header">{HeaderName}</h1>
            <Link to={next} className="change-page-button">&gt;</Link>
            </div>
    );
}