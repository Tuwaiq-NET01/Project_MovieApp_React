import React, { Component } from 'react';
import FilmRow from './FilmRow';
import { useState, useEffect } from 'react';
import { useSelector } from 'react-redux';
import { useTranslation, Trans } from 'react-i18next'
const langs = {
  en: "English",
  ar: "العربية"
}

function FilmListing (props) {

    const [filters, setfilters] = useState("all")
    const { i18n } = useTranslation()

    const handleFilterClick = (filter) => {
        setfilters(filter)
    }

        
        const { films, faves} = props;
        const movieList = useSelector(state => state.movieList)

        let showFilms = [];
        const allFilms = films.map((film) => <FilmRow key={film.id} film={film} isFave={movieList.includes(film)} onFaveToggle={() => props.onFaveToggle(film)}  handleDetailsClick ={props.handleDetailsClick}/>)
        const favesFilms = movieList.map((film) => <FilmRow key={film.movie.id} film={film.movie} isFave={movieList.includes(film)} onFaveToggle={() => props.onFaveToggle(film)} handleDetailsClick ={props.handleDetailsClick}/>)
        filters === "all" ? showFilms = allFilms : showFilms = favesFilms
       
        return(
            <div className="film-list" >
                
      {Object.keys(langs).map((lang) => (
        <button className={`film-list-filter`} onClick={() => i18n.changeLanguage(lang)} >{langs[lang]}</button>
      ))}

                <h1 className="section-title"><Trans i18nKey="FILMS">FILMS</Trans></h1>
                    <div className="film-list-filters">
                        <div onClick={() => handleFilterClick('all')} className={`film-list-filter ${filters === 'all' ? 'is-active' : ''}`}>
                        <Trans i18nKey="ALL">ALL</Trans>
                            <span className="section-count">{films.length}</span>
                        </div>
                        <div onClick={() => handleFilterClick('faves')} className={`film-list-filter ${filters === 'faves' ? 'is-active' : ''}`}>
                        <Trans i18nKey="FAVES">FAVES</Trans>
                            <span className="section-count">{movieList.length}</span>
                        </div>
                     </div>
                        {showFilms}       
            </div>
        );
    }

export default FilmListing;



