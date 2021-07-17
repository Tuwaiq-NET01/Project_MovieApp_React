import { createStore } from "redux"
import allReducers from "./reducers"

const initialState = {
  save: []
}

const store = createStore(
  allReducers,
  initialState
    )

export default store
