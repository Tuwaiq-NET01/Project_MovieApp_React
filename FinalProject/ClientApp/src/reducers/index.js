import counterReducer from "./counter";
import loggedReducer from "./isLogged";
import favMoviesList from "./favMoviesList";
import user from "./user";

import { combineReducers } from "redux";

const allReducers = combineReducers({
  counter: counterReducer,
  logged: loggedReducer,
  user,
  favMoviesList,
});

export default allReducers;
