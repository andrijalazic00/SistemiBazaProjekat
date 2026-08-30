import { StrictMode } from 'react'
import { createRoot } from 'react-dom/client'
import './index.css'
import App from './App.jsx'
import MainPage from './pages/MainPage.jsx'
import {BrowserRouter, Route, Routes} from "react-router"
import Istrazivac from './pages/Istrazivac.jsx'
import IstrazivackiRezultat from './pages/IstrazivackiRezultat.jsx'
import NaucnoIstrazivackaInstitucija from './pages/NaucnoIstrazivackaInstitucija.jsx'

createRoot(document.getElementById('root')).render(
  <StrictMode>
    <div className=' flex bg-linear-to-t from-emerald-200 to-cyan-700 w-screen h-screen align-middle justify-center'>
    <BrowserRouter>
      <Routes>
        <Route  path="/" element= {<App />}/>
        <Route path = "mainpage" element = {<MainPage />} >
          {/* Rute za Razlicite Delove Baze */}
          <Route path="istrazivac" element ={ <Istrazivac />} />
          <Route path="istrazivackirezultat" element ={<IstrazivackiRezultat />}/>
          <Route path="naucnoistrazivackainstitucija" element ={<NaucnoIstrazivackaInstitucija />}/>
        </Route>
      </Routes>
    </BrowserRouter>
    </div>
  </StrictMode>,
)
