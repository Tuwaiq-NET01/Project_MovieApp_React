
import favorites from "./favorites"


import { combineReducers } from 'redux'

const allReducers = combineReducers({
    favorites: favorites,
})

export default allReducers;