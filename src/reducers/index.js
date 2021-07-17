import addFavorite from './favoriteList'
import { combineReducers } from 'redux'

const allReducers = combineReducers({
    favoriteList: addFavorite
})

export default allReducers;