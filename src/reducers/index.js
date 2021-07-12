import counterReducer from './counter'
import loginReducer from './login'

import { combineReducers } from 'redux'

const allReducers = combineReducers({
  counter: counterReducer,
  login: loginReducer,
})

export default allReducers
