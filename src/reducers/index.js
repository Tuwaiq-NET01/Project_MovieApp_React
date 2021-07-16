import counterReducer from "./counter";
import loginReducer from "./login";
import favoriteReducer from "./Favorite";
import { combineReducers } from "redux";

const allReducers = combineReducers({
  counter: counterReducer,
  login: loginReducer,
  favorite: favoriteReducer,
});

export default allReducers;
