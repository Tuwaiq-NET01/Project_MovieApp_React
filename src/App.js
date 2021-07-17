import './App.css';
import  React,{ useState,useEffect } from 'react';
import 'bootstrap/dist/css/bootstrap.min.css';
import Navbar from './components/Navbar';
import { useTranslation, Trans } from 'react-i18next'

const langs = {
    en: "English",
    ar: "Arabic"
  }
  

function App() {
    const { i18n } = useTranslation()


    
    return (
      
        <div>
             {Object.keys(langs).map((lang) => (
        <button
          style={{ fontWeight: i18n.language === lang ? "bold" : "normal" }}
          onClick={() => i18n.changeLanguage(lang)}
        >{langs[lang]}
        </button>
      ))}
            <Navbar />

            
        </div>
    )
} export default App;
