import { SEARCH_MOVIE, FETCH_MOVIES, FETCH_MOVIE, LOADING } from "./types";
import axios from "axios";

import { APIKey } from "../APIKey";

export const searchMovie = (text) => (dispatch) => {
  dispatch({
    type: SEARCH_MOVIE,
    payload: text,
  });
};

export const fetchMovies = (text) => (dispatch) => {
  axios
    .get(
      `https://api.themoviedb.org/3/search/multi?api_key=${APIKey}&language=en-US&query=${text}&page=1&include_adult=false`
    )
    .then((response) => {
      console.log(response);
      dispatch({
        type: FETCH_MOVIES,
        payload: response.data.results,
      });
    })
    .catch((err) => console.log(err));
};

export const fetchMovie = (id) => (dispatch) => {
  axios
    .get(
      `https://api.themoviedb.org/3/movie/${id}?api_key=5eaa509ebcd4694a8e4976394d789d28&language=en-US`
    )
    .then((response) => {
      console.log(response);
      dispatch({
        type: FETCH_MOVIE,
        payload: response.data,
      });
    })
    .catch((err) => console.log(err));
};

export const setLoading = () => {
  return {
    type: LOADING,
  };
};
