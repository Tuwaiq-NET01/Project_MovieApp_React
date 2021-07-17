import React, { useState, useEffect } from 'react'
import { Link, BrowserRouter as Router , Switch, Route} from "react-router-dom";
import Detail from './Detail';
import Favorite from "./Favorite";
import { initReactI18next } from 'react-i18next'
import languageDetector from 'i18next-browser-languagedetector'
import { useTranslation, Trans } from 'react-i18next'
import i18n from 'i18next'
import Homepage from "./Homepage";
import Search from "./Search";
i18n.use(initReactI18next).use(languageDetector).init({
  resources: {
       en: {
           
           translation: {
             
               Search:"Search",
               Favorites:"Favorites",
               AllMovies:"All Movies",
               MovieApp:" MovieApp",
               
           }
       },
       ar: {
           
           translation: {
             
               Search: "ابحث",
               Favorites:"المفضلة",
               AllMovies:"كل الأفلام",
               MovieApp:"تطبيق الأفلام"

               
           }
       }
   }
})
export default function Navbar() {
    const { i18n } = useTranslation()

    const langs = {
        en: "English",
        ar: "Arabic"
      }
  const [searchRes, setSearchRes] = useState("");

  return (
    <>
      <Router>
        <nav class="navbar navbar-expand-lg navbar-light bg-light">
          <div class="container-fluid">
            <Link className='navbar-brand ms-5' to='/'>

            {Object.keys(langs).map((lang) => (
        <button 
          style={{ fontWeight: i18n.language === lang ? "bold" : "normal" }}
          onClick={() => i18n.changeLanguage(lang)}
        >{langs[lang]}
        </button>
      ))}


            <Trans i18nKey=" MovieApp">
            MovieApp </Trans> 
            </Link>

            <div class="collapse navbar-collapse" id="navbarSupportedContent">
              <ul class="navbar-nav me-auto mb-2 mb-lg-0">
                <li class="nav-item">
                  <Link to="/" className="nav-link" aria-current="page">
                  <Trans i18nKey="AllMovies">
          All Movies </Trans></Link>


                </li>
                <li class="nav-item">
                  <Link to="/favorites" className="nav-link">
                  <Trans i18nKey="Favorites">
          Favorites
        </Trans>
                  </Link>
                </li>
              </ul>
              <form class="d-flex">
                <input
                  class="form-control me-3"
                  type="search"
                  placeholder="Search"
                  aria-label="Search"
                  onChange={(e) => setSearchRes(e.target.value)}
                />

<Link className="me-5" to="/search">
                  <button class="btn btn-secondary" type="submit">
                  <Trans i18nKey="Search">
          Search
        </Trans>                  </button>
                </Link>
              </form>
            </div>
          </div>
        </nav>

    <Switch>
        <Route
              exact
              path="/"
              render={() => <Homepage />}
            />

              
<Route
              exact
              path="/favorites"
              render={() => <Favorite />}
            />

    <Route
              exact
              path="/search"
              render={() => <Search target={searchRes} />}
            />

<Route
              exact
              path="/movies/:id"
              render={() => <Detail />}
            />


    </Switch>
      </Router>
    </>
  );
}
