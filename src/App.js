import React from "react"
import { BrowserRouter as Router, Switch, Route } from "react-router-dom"
import HomeView from "./views/HomeView"
import NavBar from "./components/NavBar"

function App() {
  return (
    <div className="App">
      <Router>
        <NavBar />
        <Switch>
          <Route path="/" component={HomeView} exact />
        </Switch>
      </Router>
    </div>
  )
}

export default App
