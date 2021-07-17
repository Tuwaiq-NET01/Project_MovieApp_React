import React, { Component } from 'react';
import FilmListing from './components/FilmListing';
import FilmDetails from './components/FilmDetails';
import TMDB from './TMDB';
import axios from "axios";
import { useSelector, useDispatch } from 'react-redux';
import { movieAdded, movieRemoved } from './action';
import { useState, useEffect } from 'react';

function App() {

  const [films, setfilms] = useState(TMDB.films)
  var [faves, setfaves] = useState([])
  const [current, setCurrent] = useState({})

  const movieList = useSelector(state => state.movieList)
  console.log(movieList)
  const dispatch = useDispatch();


  // const handelSubmit = (event) => {
  //   event.preventDefault()
  //   dispatch(movieAdded(current))
  // }


  const handleFaveToggle = (film) => {

     faves = [...faves];
    const filmIndex = movieList.indexOf(film)

    if (filmIndex !== -1) {
      // faves.splice(filmIndex, 1);
      dispatch(movieRemoved(film))
    } else {
      // faves.push(film);
      dispatch(movieAdded(film))
    }
    setfaves( faves )
  }

  const handleDetailsClick = (film) => {
    console.log(TMDB.api_key)
    console.log(film.id)

    const url = `https://api.themoviedb.org/3/movie/${film.id}?api_key=971e7f39082bed8b9cf805e1bf9cf859&append_to_response=videos,images&language=en`

    axios({
      method: 'GET',
      url: url
    }).then(response => {
      setCurrent({ current: response.data })
    })
      .catch(e => {
        console.log(`There is an Error With axios ${e}`)
      });
  }

    return (
      <div className="film-library">
        <FilmListing handleDetailsClick={handleDetailsClick} films={films}  onFaveToggle={handleFaveToggle} />
        {/* <FilmDetails film={current} /> */}
      </div>
    );
}

export default App;
