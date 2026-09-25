import { useState } from 'react'
import { Outlet, Link } from "react-router";
import './App.css'

function App() {
 return(
        <div className=' flex flex-col justify-center'>
            <div className=' bg-blue-800 w-screen'>
                <h1 className=' text-7xl p-5 font-serif text-left m-10'> Repozitorijum </h1>
            </div>

 
            <div className=' flex flex-col bg-blue-500 w-screen'>
                <Link to="mainpage/istrazivaci" className="main-button-design">Istrazivaci</Link>
                <Link to="mainpage/istrazivacki_rezultati" className="main-button-design">Istrazivacki Rezultati</Link>
                <Link to="mainpage/publikacija" className="main-button-design">Publikacije</Link>
                <Link to="mainpage/naucno_istrazivacka_institucija" className="main-button-design">Naucno Istrazivacke Institucije</Link>
            </div>
        </div>
 )
}

export default App
