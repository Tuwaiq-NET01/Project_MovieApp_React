import { MovieCard } from './MovieCard.js'
import axios from 'axios'
import React, { useState, useEffect } from 'react';
import { positions, Provider } from "react-alert";
import AlertTemplate from "react-alert-template-basic";


let type = [
  'cold',
  'city',
  'life',
  'good',
  'dark',
  'real',
  'army',
  'fight',
  'war',
  'family',
  'holiday',
]
const options = {
  timeout: 1500,
  position: positions.BOTTOM_CENTER
};

class Movies extends React.Component {
  constructor(props) {
    super(props)
    this.state = {
      movies: [],
    }
  }

  componentDidMount() {
    localStorage.setItem("LoggedIn", "false");
    type.map((t) => {
      axios 
        .get(`https://api.themoviedb.org/3/search/movie?api_key=a01e9d385be14a17335bf30943ca723a&page=1&query=${t}`)
        .then((res) => {
          console.log(res.data.results);
          const allMovies = res.data.results;
          allMovies.InMyList = false;
          this.setState({ movies: [...this.state.movies, ...allMovies] }); //another array
        })
        .catch((error) => console.error(`Error:  ${error}`))
    })
   
  }
  render() {
    return (
      <>
        <div className="flexbox-container ">
          {this.state.movies.map((movie) => {
            return (
              <Provider template={AlertTemplate} {...options}>
                <MovieCard
                  MovieList={this.props.MovieList}
                  Movie={movie}
                ></MovieCard>
              </Provider>
            )
          })}
        </div>
      </>
    )
  }
}
export default Movies
