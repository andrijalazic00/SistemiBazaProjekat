import { StrictMode } from 'react'
import { createRoot } from 'react-dom/client'
import './index.css'
import App from './App.jsx'
import MainPage from './pages/MainPage.jsx'
import {BrowserRouter, Route, Routes} from "react-router"

createRoot(document.getElementById('root')).render(
  <StrictMode>
    <BrowserRouter>
      <Routes>
        <Route  path="/" element= {<App />}/>
        <Route path = "mainpage" element = {<MainPage />} >
          {/* Rute za Razlicite Delove Baze */}
        </Route>
      </Routes>
    </BrowserRouter>
  </StrictMode>,
)
