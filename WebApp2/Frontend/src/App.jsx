import { useState } from 'react'
import { Outlet, Link } from "react-router";
import './App.css'

function App() {
 return(
        <div className=' flex flex-col align-middle justify-center'>
            <h1 className=' text-7xl p-5 font-serif font-bold'> Repozitorijum </h1>
            <Link to="mainpage" className=' font-mono font-bold text-2xl bg-blue-600 border-4 p-3 rounded-3xl hover:bg-linear-to-b from-blue-600 to-emerald-200  text-center'> Pristup Repozitorijumu</Link> 
        </div>
 )
}

export default App
