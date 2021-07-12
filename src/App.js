import React, { useState } from 'react'
import { BrowserRouter as Router, Switch, Route } from 'react-router-dom'
import HomeView from './views/HomeView'
import LoginView from './views/LoginView'
import ErrorView from './views/ErrorView'
import NavBar from './components/NavBar'

function App() {
  return (
    <div className="App">
      <Router>
        <NavBar />
        <Switch>
          <Route path="/" component={HomeView} exact />
          <Route path="/login" component={LoginView} />
          {/* <Route path="/repo/:id" component={Repo} /> */}
          <Route component={ErrorView} />
        </Switch>
      </Router>
    </div>
  )
}

export default App
