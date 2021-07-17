import saveReducer from "./save";
import { combineReducers } from "redux";

const allReducers = combineReducers({
  save: saveReducer
});

export default allReducers;
