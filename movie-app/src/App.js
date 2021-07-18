import React, { Component } from "react";
import { useTranslation, Trans } from 'react-i18next'
import MovieResults from "./components/MovieResults";
import FavoriteMovieList from "./components/FavoriteMovieList";
import { BrowserRouter as Router, Switch, Route } from "react-router-dom";
import PreLoader1 from "./PreLoader1";
const langs = {
  en: "English",
  ar: "Arabic"
}

export default function App() {
  const { i18n } = useTranslation()

  return (
    <div>
       <div className="container">
        <div className="row text-center">
          <div className="Header">
          
            <h1>
            <Trans i18nKey="Movies">
            Movies App
            </Trans>
            </h1>
            
            <p>
            <Trans i18nKey="Who">
            Who doesn't Love movies?
            </Trans>
            </p>
          </div>
          {Object.keys(langs).map((lang) => (
        <button
          style={{ fontWeight: i18n.language === lang ? "bold" : "normal" }}
          onClick={() => i18n.changeLanguage(lang)}
        >{langs[lang]}
        </button>
    
      ))}
      <PreLoader1/>
      
        </div>
        <div className="row" >
       
          <Router>
            <Switch>
              <Route exact path="/" component={MovieResults} />
              <Route path="/fav" component={FavoriteMovieList} />
              
            </Switch>
          </Router>
       
        </div>
      </div>
    </div>
  )
}


