import { createStore } from 'redux'
import allReducers from './reducers'

const initialState = {
  counter: 10,
  login: false,
}

const store = createStore(
  allReducers,
  initialState,
  window.__REDUX_DEVTOOLS_EXTENSION__ && window.__REDUX_DEVTOOLS_EXTENSION__()
)

export default store
