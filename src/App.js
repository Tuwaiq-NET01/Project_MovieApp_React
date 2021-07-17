import React from "react"
import { BrowserRouter as Router, Switch, Route } from "react-router-dom"
import HomeView from "./views/HomeView"
import LoginView from "./views/LoginView"
import ErrorView from "./views/ErrorView"
import SearchView from "./views/SearchView"
import MovieView from "./views/MovieView"
import FavoritesView from "./views/FavoritesView"
import NavBar from "./components/NavBar"
import { useTranslation, Trans } from 'react-i18next'
function App() {
  const { i18n } = useTranslation()
  return (
    <div className="App">
      <Router>
        <NavBar i18n={i18n}/>
        <Switch>
          <Route path="/" component={HomeView} exact />
          <Route path="/favorites" component={FavoritesView} />
          <Route path="/search" component={SearchView} />
          <Route path="/login" component={LoginView} />
          <Route path="/movie/:id" component={MovieView} />
          <Route component={ErrorView} />
        </Switch>
      </Router>
    </div>
  )
}

export default App
