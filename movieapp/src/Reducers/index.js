import movies from "./movies-reducer";
import { combineReducers } from "redux";
import favorites from "./fav-reducer";


const rootReducer = combineReducers({
  movies,
  favorites,
});

export default rootReducer;