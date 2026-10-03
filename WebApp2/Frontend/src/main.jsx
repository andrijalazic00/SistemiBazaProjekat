import { StrictMode } from 'react'
import { createRoot } from 'react-dom/client'
import './index.css'
import App from './App.jsx'
import {BrowserRouter, Route, Routes} from "react-router"

//Pages
import MainPage from "./pages/RepoPages/MainPage.jsx"
import Istrazivaci from "./pages/RepoPages/IstrazivaciPage.jsx"
import Istrazivacki_rezultati from "./pages/RepoPages/IstrazivackiRezultatiPage.jsx"
import Publikacija from "./pages/RepoPages/PublikacijaPage.jsx"
import Naucno_Istrazivacka_Institucija from "./pages/RepoPages/NaucnoIstrazivackeInstitucijePage.jsx"

createRoot(document.getElementById('root')).render(
  <StrictMode>
    <div className=' bg-repeat flex bg-linear-to-t from-blue-700 to-blue-950 w-screen h-screen justify-center'>
    <BrowserRouter>
      <Routes>
        <Route  path="/" element= {<App />}/>
        <Route path='mainpage' element= {<MainPage />}>
              <Route path='istrazivaci' element={<Istrazivaci />}/>
              <Route path='istrazivacki_rezultati' element={<Istrazivacki_rezultati />}/>
              <Route path='publikacija' element={<Publikacija />}/>
              <Route path='naucno_istrazivacka_institucija' element={<Naucno_Istrazivacka_Institucija />}/>
        </Route>
      </Routes>
    </BrowserRouter>
    </div>
  </StrictMode>,
)
